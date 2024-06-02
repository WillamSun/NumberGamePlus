using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Windows.Forms;
using NumberGamePlus.Components;

namespace NumberGamePlus
{
    public partial class MainForm : Form
    {
        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                score_lbl.Text = value.ToString();
            }
        }

        public static readonly string GameName = NumberSmash.Properties.Resources.GameName;

        private int _score = 0;

        public int HelpUsedTime
        {
            get => _help_used_time;
            set
            {
                _help_used_time = value;
                help_time_lbl.Text = value.ToString();
            }
        }

        private int _help_used_time = 0;

        public readonly Random RandomGenerator;
        public MainForm()
        {
            InitializeComponent();
#if WITHOUTBSOD
            bSoDWhenLoseToolStripMenuItem.Visible = false;
#endif
            Text = GameName;
            RandomGenerator = new Random();
            equation.RandomGenerator = RandomGenerator;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            equation.InitNumbers();
            timer1.Start();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= equation.Numbers.Count() + '0' && e.KeyChar > '0')
                equation.Numbers[e.KeyChar - '0' - 1].Selected ^= true;
            switch (e.KeyChar)
            {
                case '+':
                    fontToolStripMenuItem_Click(sender, e);
                    break;
                case '-':
                    fontToolStripMenuItem1_Click(sender, e);
                    break;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font = new Font(Font.FontFamily, Font.Size + 1);
            menuStrip1.Font = new Font(menuStrip1.Font.FontFamily, menuStrip1.Font.Size + 1);
            statusStrip1.Font = new Font(statusStrip1.Font.FontFamily, statusStrip1.Font.Size + 1);
            equation.Font = new Font(equation.Font.FontFamily, equation.Font.Size + 1);
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Font.Size > 1)
                Font = new Font(Font.FontFamily, Font.Size - 1);
            if (menuStrip1.Font.Size > 1)
                menuStrip1.Font = new Font(menuStrip1.Font.FontFamily, menuStrip1.Font.Size - 1);
            if (statusStrip1.Font.Size > 1)
                statusStrip1.Font = new Font(statusStrip1.Font.FontFamily, statusStrip1.Font.Size - 1);
            if (equation.Font.Size > 1)
                equation.Font = new Font(equation.Font.FontFamily, equation.Font.Size - 1);
        }

        private void groupBoxScore_Resize(object sender, EventArgs e)
        {
            var lblWidth = score_lbl.Width;
            if (lblWidth <= 0) return;
            var size = score_lbl.Font.Size;
            score_lbl.AutoSize = true;
            score_lbl.Dock = DockStyle.None;
            if (score_lbl.Width > lblWidth)
                while (score_lbl.Width > lblWidth)
                {
                    size -= 0.25F;
                    if (size <= 0) return;
                    score_lbl.Font = new Font(score_lbl.Font.FontFamily, size, FontStyle.Regular, GraphicsUnit.World);
                }
            else if (score_lbl.Width < lblWidth)
                while (score_lbl.Width < lblWidth)
                {
                    size += 0.25F;
                    score_lbl.Font = new Font(score_lbl.Font.FontFamily, size, FontStyle.Regular, GraphicsUnit.World);
                }
            score_lbl.AutoSize = false;
            score_lbl.Dock = DockStyle.Fill;
            score_lbl.Width = lblWidth;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            void InitSelectedNumbers()
            {
                foreach (var n in equation.SelectedItems)
                {
                    n.InitNumber();
                    n.Selected = false;
                }
                toolStripProgressBarTime.Value = 0;
            }
            string ConnectNumbers(Number[] numbers)
                => string.Concat(numbers.Select((l, i) => i == 0 ? l.Text : "+" + l.Text));
            if (equation.SelectedItems.Count() <= 0 || equation.SelectedSum == int.MinValue)
            {
                var suitable = Algorithms.Algorithms.Get0Groups(equation.Values.ToArray());
                if (suitable.Length == 0)
                {
                    equation.InitNumbers();
                    return;
                }
                Lose(string.Concat(
                    suitable
                    .Select(i => ConnectNumbers(
                        i.Select(j => equation.Numbers[j]).ToArray()) + "\n")));
                return;
            }
            var checkresult = equation.CheckedStatus;
            if (checkresult.ContainsNull)
            {
                equation.InitNumbers();
                equation.SelectedIndices = new int[] { };
                return;
            }
            if (checkresult.ContainsInfinitives)
            {
                InitSelectedNumbers();
                return;
            }
            if (checkresult.Overall)
            {
                InitSelectedNumbers();
                if (checkresult.ContainsDouble)
                {
                    Score += 2;
                    return;
                }
                Score++;
                return;
            }
            if (checkresult.ContainsUnknown)
            {
                InitSelectedNumbers();
                if (checkresult.ContainsDouble)
                {
                    Score -= 2;
                    return;
                }
                Score--;
                return;
            }
            if (equation.CheckedStatus.ContainsSignums)
            {
                Lose(string.Format("{0} = {1} ≠ 0",
                    ConnectNumbers(equation.SelectedItems),
                    string.Concat(equation.CheckedStatus.Possibilities.Select((l, i) => i == 0 ? l.ToString() : ", " + l.ToString()))
                    ));
                return;
            }
            Lose(string.Format("{0} = {1} ≠ 0",
                ConnectNumbers(equation.SelectedItems),
                equation.SelectedSum));
        }

        private DialogResult ShowMessageBox(string message, string title = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            DialogResult result;
            pause_cbx.Checked = true;
            result = MessageBox.Show(message, title, buttons, icon);
            pause_cbx.Checked = false;
            return result;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            if (!game_over && ShowMessageBox("Sure to reset?\nAll progress will be lost",
                "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) ==
                DialogResult.Cancel) return;
            seconds = hundred_milliseconds = Score = HelpUsedTime = 0;
            timing_lbl.Text = "0:00";
            pause_lbl.Text = "Game Paused";
            pause_lbl.Visible = false;
            equation.SelectedItems = new Number[] { };
            equation.InitNumbers();
            SetEnabled(this, true, null);
            SetMenuStripEnabled(menuStrip1, true, null, null);
            game_over = false;
            if (!timer1.Enabled)
                timer1.Start();
            toolStripProgressBarTime.Value = 0;
        }

        private void equation_SelectedItemsChanged(object sender, EventArgs e)
        {
            var selected_items_length = equation.SelectedItems.Length;
            if (selected_items_length == 0 || equation.SelectedSum == int.MinValue)
            {
                submitToolStripMenuItem.Text = submit_btn.Text = "Refre&sh";
                selectAllToolStripMenuItem.Checked = select_all_cbx.Checked = false;
            }
            else
            {
                submitToolStripMenuItem.Text = submit_btn.Text = "&Submit";
                selectAllToolStripMenuItem.CheckState = select_all_cbx.CheckState = CheckState.Indeterminate;
                if (selected_items_length == equation.Numbers.Count)
                    selectAllToolStripMenuItem.CheckState = select_all_cbx.CheckState = CheckState.Checked;
            }
            UpdateSumLabel();
        }

        private void UpdateSumLabel()
        {
            if (showSumToolStripMenuItem.Checked)
            {
                var checkedstatus = equation.CheckedStatus;
                var selected_sum = equation.SelectedSum;
                toolStripProgressBarSumAbs.Maximum = Math.Max(equation.MaxSum, Math.Abs(equation.MinSum));
                if (equation.SelectedItems.Length <= 0 || selected_sum == int.MinValue)
                {
                    toolStripProgressBarSumAbs.Value = 0;
                    toolStripStatusLabelSumAbs.Text = "Sum: None";
                    toolStripStatusLabelSumAbs.ForeColor = Color.Red;
                    return;
                }
                if (checkedstatus.ContainsNull)
                {
                    toolStripProgressBarSumAbs.Value = 0;
                    toolStripStatusLabelSumAbs.Text = "Sum: Null";
                    toolStripStatusLabelSumAbs.ForeColor = Color.YellowGreen;
                    return;
                }
                if (checkedstatus.ContainsInfinitives)
                {
                    toolStripProgressBarSumAbs.Value = 0;
                    toolStripStatusLabelSumAbs.Text = "Sum: ∞";
                    toolStripStatusLabelSumAbs.ForeColor = Color.Green;
                    return;
                }
                if (checkedstatus.ContainsTimesZero)
                {
                    toolStripProgressBarSumAbs.Value = 0;
                    toolStripStatusLabelSumAbs.Text = "Sum: 0";
                    toolStripStatusLabelSumAbs.ForeColor = Color.Green;
                    return;
                }
                if (checkedstatus.ContainsSignums)
                {
                    var possibilities = checkedstatus.Possibilities;
                    toolStripProgressBarSumAbs.Value = 0;
                    toolStripStatusLabelSumAbs.Text = "Sum: " + string.Join(", ", possibilities);
                    if (checkedstatus.Overall)
                    {
                        toolStripStatusLabelSumAbs.ForeColor = Color.Green;
                        return;
                    }
                    toolStripStatusLabelSumAbs.ForeColor = Color.Red;
                    return;
                }
                if (checkedstatus.ContainsUncommonNumber && !checkedstatus.ContainsDouble)
                {
                    toolStripProgressBarSumAbs.Value = 0;
                    toolStripStatusLabelSumAbs.Text = "Sum: NaN";
                    toolStripStatusLabelSumAbs.ForeColor = Color.Red;
                    return;
                }
                toolStripProgressBarSumAbs.Value = Math.Abs(selected_sum);
                toolStripStatusLabelSumAbs.Text = "Sum: " + selected_sum.ToString();
                toolStripStatusLabelSumAbs.ForeColor = SystemColors.ControlText;
                if (selected_sum == 0)
                    toolStripStatusLabelSumAbs.ForeColor = Color.Green;
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            var suitable = Algorithms.Algorithms.Get0Groups(equation.Values.ToArray());
            if (suitable.Length <= 0)
            {
                ShowMessageBox("There is no solution!\nTry refresh", "No Solution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var solution = suitable[RandomGenerator.Next(suitable.Length)];
            equation.SelectedIndices = solution;
            HelpUsedTime++;
        }

        private void select_all_cbx_Click(object sender, EventArgs e)
        {
            var check_flag = false;
            if (sender == select_all_cbx)
                check_flag = selectAllToolStripMenuItem.Checked = select_all_cbx.Checked;
            else if (sender == selectAllToolStripMenuItem)
                check_flag = select_all_cbx.Checked = selectAllToolStripMenuItem.Checked;
            if (check_flag)
            {
                equation.SelectedItems = equation.Numbers.ToArray();
                return;
            }
            equation.SelectedItems = new Number[] { };
        }

        private void Pause(bool toggle)
        {
            var exclusive = new Control[]
            {
                this,
                tableLayoutPanel1,
                tableLayoutPanel2,
                tableLayoutPanel4,
                tableLayoutPanel6,
                groupBoxActions,
                pause_cbx,
                menuStrip1,
                statusStrip1
            };
            var exclusive_tsmi = new ToolStripMenuItem[]
            {
                gameToolStripMenuItem,
                pauseToolStripMenuItem,
                viewToolStripMenuItem,
                fontToolStripMenuItem,
                fontToolStripMenuItem1,
                topMostToolStripMenuItem,
                optionsToolStripMenuItem,
                showSumToolStripMenuItem,
                aboutToolStripMenuItem,
                howtoplayToolStripMenuItem1,
                authorToolStripMenuItem,
                timingToolStripMenuItem,
                aboutToolStripMenuItem
            };
            SetEnabled(this, !toggle, exclusive);
            SetMenuStripEnabled(menuStrip1, !toggle, exclusive_tsmi, null);
            toolStripTextBoxTiming.Enabled = true;
            pause_lbl.Visible = toggle;
            equation.Visible = !toggle;
            pause_cbx.Checked = toggle;
            if (toggle) timer1.Stop();
            else timer1.Start();
        }

        private void SetMenuStripEnabled(ToolStripMenuItem root, bool value, ToolStripMenuItem[] exclusive, ToolStripTextBox[] exclusive_tb)
        {
            foreach (var obj in root.DropDownItems)
                if (obj is ToolStripMenuItem tsmi)
                    SetMenuStripEnabled(tsmi, value, exclusive, exclusive_tb);
                else if (obj is ToolStripTextBox tstb)
                {
                    if (exclusive_tb == null)
                    {
                        tstb.Enabled = value;
                        return;
                    }
                    foreach (var e in exclusive_tb)
                        if (tstb == e) return;
                    tstb.Enabled = value;
                }
            if (exclusive == null)
            {
                root.Enabled = value;
                return;
            }
            foreach (var e in exclusive)
                if (root == e) return;
            root.Enabled = value;
        }

        private void SetMenuStripEnabled(MenuStrip root, bool value, ToolStripMenuItem[] exclusive, ToolStripTextBox[] exclusive_tb)
        {
            foreach (ToolStripMenuItem tsmi in root.Items)
                SetMenuStripEnabled(tsmi, value, exclusive, exclusive_tb);
        }

        private void SetEnabled(Control root, bool value, Control[] exclusive)
        {
            foreach (Control control in root.Controls)
                SetEnabled(control, value, exclusive);
            if (exclusive == null)
            {
                root.Enabled = value;
                return;
            }
            foreach (var e in exclusive)
                if (root == e) return;
            root.Enabled = value;
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
            => TopMost = topMostToolStripMenuItem.Checked;

        private void pause_cbx_CheckedChanged(object sender, EventArgs e)
        {
            var check_flag = false;
            if (sender == pause_cbx)
                check_flag = pauseToolStripMenuItem.Checked = pause_cbx.Checked;
            else if (sender == pauseToolStripMenuItem)
                check_flag = pause_cbx.Checked = pauseToolStripMenuItem.Checked;
            Pause(check_flag);
        }

        private int hundred_milliseconds = 0;
        private long seconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*seconds++;
            timing_lbl.Text = string.Format("{0}:{1:00}", seconds / 60, seconds % 60);*/
            hundred_milliseconds++;
            if (hundred_milliseconds == 5)
            {
                seconds++;
                timing_lbl.Text = string.Format("{0}:{1:00}", seconds / 60, seconds % 60);
                hundred_milliseconds = 0;
                if (timingToolStripMenuItem.Checked)
                {
                    if (toolStripProgressBarTime.Value < timing)
                    {
                        toolStripProgressBarTime.Value++;
                        toolStripStatusTime.Text = string.Format("Time Remaining: {0}s", timing - toolStripProgressBarTime.Value);
                    }
                    else
                        Invoke(new Action(() => Lose("Time is up!")));
                }
            }
        }

        private void showSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBarSumAbs.Visible = toolStripStatusLabelSumAbs.Visible = showSumToolStripMenuItem.Checked)
                UpdateSumLabel();
        }

        private void Lose(string reason)
        {
            Control[] exclusive = new Control[]
            {
                this,
                tableLayoutPanel1,
                tableLayoutPanel2,
                tableLayoutPanel4,
                tableLayoutPanel6,
                groupBoxActions,
                reset_btn,
                menuStrip1,
                statusStrip1
            };
            ToolStripMenuItem[] exclusive_tsmi = new ToolStripMenuItem[]
            {
                gameToolStripMenuItem,
                pauseToolStripMenuItem,
                viewToolStripMenuItem,
                fontToolStripMenuItem,
                fontToolStripMenuItem1,
                topMostToolStripMenuItem,
                optionsToolStripMenuItem,
                showSumToolStripMenuItem
            };
            SetEnabled(this, false, exclusive);
            SetMenuStripEnabled(menuStrip1, false, exclusive_tsmi, null);
            equation.SelectedItems = new Number[] { };
            pause_lbl.Text = "Game Over\n" + reason;
            pause_lbl.Visible = game_over = true;
            timer1.Stop();
#if WITHOUTBSOD == false
            if (bSoDWhenLoseToolStripMenuItem.Checked) Algorithms.Algorithms.BSoD();
#endif
        }

        bool game_over = false;

        private void toolStripTextBoxTiming_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0') return;
            if (e.KeyChar == '\b') return;
            e.Handled = true;
        }

        int timing = 10;

        private void timingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timingToolStripMenuItem.Text = "Timing" + (timingToolStripMenuItem.Checked ? " (s):" : "");
            toolStripTextBoxTiming.Visible =
                toolStripProgressBarTime.Visible =
                toolStripStatusTime.Visible = timingToolStripMenuItem.Checked;
        }

        private void toolStripTextBoxTiming_TextChanged(object sender, EventArgs e)
        {
            if (timingToolStripMenuItem.Checked)
            {
                toolStripProgressBarTime.Value = 0;
                if (toolStripTextBoxTiming.Text == "") return;
                int.TryParse(toolStripTextBoxTiming.Text, out timing);
                if (timing <= 0)
                {
                    toolStripTextBoxTiming.Text = "10";
                    timing = 10;
                    var paused = pauseToolStripMenuItem.Checked;
                    Pause(true);
                    MessageBox.Show("The specific number is to large or to small!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pause(paused);
                    return;
                }
                toolStripStatusTime.Text = "Time Remaining: " + timing + "s";
                toolStripProgressBarTime.Maximum = timing;
            }
        }

        private void bSoDWhenLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if WITHOUTBSOD == false
            var paused = pause_cbx.Checked;
            if (bSoDWhenLoseToolStripMenuItem.Checked)
            {
                toolStripStatusLabelBSoD.Visible = bSoDWhenLoseToolStripMenuItem.Checked = false;
                return;
            }
            Pause(true);
            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
            if (!principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("Please run this program as administrator before using this function", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pause(paused);
                return;
            }
            if (MessageBox.Show(NumberSmash.Properties.Resources.WarnForBSoD, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel) return;
            bSoDWhenLoseToolStripMenuItem.Checked = toolStripStatusLabelBSoD.Visible = true;
            Pause(paused);
#endif
        }

        private void extendedFeaturesToggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var paused = pause_cbx.Checked;
            var check = extendedFeaturesToggleToolStripMenuItem.Checked;
            Pause(true);
            if (check)
                MessageBox.Show(NumberSmash.Properties.Resources.TipForExtFea,
                    "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            equation.ExtendedFeaturesToggle = check;
            toolStripStatusLabelExtFea.Visible = check;
            Pause(paused);
        }

        private void howtoplayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var flag = false;
            var paused = pause_cbx.Checked;
            Pause(true);
            for (var i = 1; i <= 6; i++)
                if (flag =
                MessageBox.Show(NumberSmash.Properties.Resources.
                    ResourceManager.GetString("HelpLine" + i)
                    + "\n\nClick 'Cancel' to exit How To Play.",
                    "How To Play", MessageBoxButtons.OKCancel)
                    == DialogResult.Cancel) break;
            if (flag) return;
            if (extendedFeaturesToggleToolStripMenuItem.Checked)
            {
                for (var i = 1; i <= 2; i++)
                    if (
                    MessageBox.Show(NumberSmash.Properties.Resources.
                        ResourceManager.GetString("ExtHelpLine" + i)
                        + "\n\nClick 'Cancel' to exit How To Play.",
                        "How To Play", MessageBoxButtons.OKCancel)
                        == DialogResult.Cancel) break;
                MessageBox.Show(NumberSmash.Properties.Resources.ExtHelpLine3, "How To Play");
            }
            else
                MessageBox.Show(NumberSmash.Properties.Resources.HelpLine7, "How To Play");
            Pause(paused);
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var paused = pause_cbx.Checked;
            Pause(true);
            MessageBox.Show(
                GameName + "\n" +
                "(C)opyright 2024 Idad Wind.\n" +
                "All rights reserved.\n" +
                "Click 'Help' to open GitHub page", "About",
                0, MessageBoxIcon.Information, 0, 0,
                "https://github.com/WillamSun/NumberSmash");
            Pause(paused);
        }

        private void resetFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font = new Font(Font.FontFamily, 7.5f, GraphicsUnit.Point);
            menuStrip1.Font = new Font(menuStrip1.Font.FontFamily, 9, GraphicsUnit.Point);
            statusStrip1.Font = new Font(statusStrip1.Font.FontFamily, 9, GraphicsUnit.Point);
            equation.Font = new Font(equation.Font.FontFamily, 7.8f, GraphicsUnit.Point);
        }
    }
} 