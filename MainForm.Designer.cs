namespace NumberGamePlus
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxTiming = new System.Windows.Forms.ToolStripTextBox();
            this.bSoDWhenLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedFeaturesToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howtoplayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.byToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBSoD = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelExtFea = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarSumAbs = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelSumAbs = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarTime = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxEquation = new System.Windows.Forms.GroupBox();
            this.pause_lbl = new System.Windows.Forms.Label();
            this.equation = new NumberGamePlus.Components.Equation();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.help_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.select_all_cbx = new System.Windows.Forms.CheckBox();
            this.pause_cbx = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTiming = new System.Windows.Forms.GroupBox();
            this.timing_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.help_time_lbl = new System.Windows.Forms.Label();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxEquation.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxTiming.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxHelp.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.submitToolStripMenuItem.Text = "Refre&sh";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.CheckOnClick = true;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pause_cbx_CheckedChanged);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.CheckOnClick = true;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.select_all_cbx_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.fontToolStripMenuItem1,
            this.resetFontToolStripMenuItem,
            this.topMostToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.fontToolStripMenuItem.Text = "Font&+";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.fontToolStripMenuItem1.Text = "Font&-";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // resetFontToolStripMenuItem
            // 
            this.resetFontToolStripMenuItem.Name = "resetFontToolStripMenuItem";
            this.resetFontToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.resetFontToolStripMenuItem.Text = "&Reset Font";
            this.resetFontToolStripMenuItem.Click += new System.EventHandler(this.resetFontToolStripMenuItem_Click);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.topMostToolStripMenuItem.Text = "Keep &Top";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSumToolStripMenuItem,
            this.timingToolStripMenuItem,
            this.toolStripTextBoxTiming,
            this.bSoDWhenLoseToolStripMenuItem,
            this.extendedFeaturesToggleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // showSumToolStripMenuItem
            // 
            this.showSumToolStripMenuItem.CheckOnClick = true;
            this.showSumToolStripMenuItem.Name = "showSumToolStripMenuItem";
            this.showSumToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.showSumToolStripMenuItem.Text = "&Show Sum";
            this.showSumToolStripMenuItem.Click += new System.EventHandler(this.showSumToolStripMenuItem_Click);
            // 
            // timingToolStripMenuItem
            // 
            this.timingToolStripMenuItem.CheckOnClick = true;
            this.timingToolStripMenuItem.Name = "timingToolStripMenuItem";
            this.timingToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.timingToolStripMenuItem.Text = "Timing";
            this.timingToolStripMenuItem.Click += new System.EventHandler(this.timingToolStripMenuItem_Click);
            // 
            // toolStripTextBoxTiming
            // 
            this.toolStripTextBoxTiming.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxTiming.Name = "toolStripTextBoxTiming";
            this.toolStripTextBoxTiming.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxTiming.Text = "10";
            this.toolStripTextBoxTiming.Visible = false;
            this.toolStripTextBoxTiming.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxTiming_KeyPress);
            this.toolStripTextBoxTiming.TextChanged += new System.EventHandler(this.toolStripTextBoxTiming_TextChanged);
            // 
            // bSoDWhenLoseToolStripMenuItem
            // 
            this.bSoDWhenLoseToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.bSoDWhenLoseToolStripMenuItem.Name = "bSoDWhenLoseToolStripMenuItem";
            this.bSoDWhenLoseToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.bSoDWhenLoseToolStripMenuItem.Text = "BSoD When Lose";
            this.bSoDWhenLoseToolStripMenuItem.Click += new System.EventHandler(this.bSoDWhenLoseToolStripMenuItem_Click);
            // 
            // extendedFeaturesToggleToolStripMenuItem
            // 
            this.extendedFeaturesToggleToolStripMenuItem.CheckOnClick = true;
            this.extendedFeaturesToggleToolStripMenuItem.Name = "extendedFeaturesToggleToolStripMenuItem";
            this.extendedFeaturesToggleToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.extendedFeaturesToggleToolStripMenuItem.Text = "Extended Features Toggle";
            this.extendedFeaturesToggleToolStripMenuItem.Click += new System.EventHandler(this.extendedFeaturesToggleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howtoplayToolStripMenuItem1,
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // howtoplayToolStripMenuItem1
            // 
            this.howtoplayToolStripMenuItem1.Name = "howtoplayToolStripMenuItem1";
            this.howtoplayToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.howtoplayToolStripMenuItem1.Text = "&How To Play";
            this.howtoplayToolStripMenuItem1.Click += new System.EventHandler(this.howtoplayToolStripMenuItem1_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.authorToolStripMenuItem.Text = "&Info";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byToolStripStatusLabel,
            this.toolStripStatusLabelBSoD,
            this.toolStripStatusLabelExtFea,
            this.toolStripProgressBarSumAbs,
            this.toolStripStatusLabelSumAbs,
            this.toolStripProgressBarTime,
            this.toolStripStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // byToolStripStatusLabel
            // 
            this.byToolStripStatusLabel.Name = "byToolStripStatusLabel";
            this.byToolStripStatusLabel.Size = new System.Drawing.Size(101, 19);
            this.byToolStripStatusLabel.Text = "By Idad Wind.";
            // 
            // toolStripStatusLabelBSoD
            // 
            this.toolStripStatusLabelBSoD.Name = "toolStripStatusLabelBSoD";
            this.toolStripStatusLabelBSoD.Size = new System.Drawing.Size(107, 19);
            this.toolStripStatusLabelBSoD.Text = "BSoD Enabled.";
            this.toolStripStatusLabelBSoD.Visible = false;
            // 
            // toolStripStatusLabelExtFea
            // 
            this.toolStripStatusLabelExtFea.Name = "toolStripStatusLabelExtFea";
            this.toolStripStatusLabelExtFea.Size = new System.Drawing.Size(191, 19);
            this.toolStripStatusLabelExtFea.Text = "Extended Features Enabled.";
            this.toolStripStatusLabelExtFea.Visible = false;
            // 
            // toolStripProgressBarSumAbs
            // 
            this.toolStripProgressBarSumAbs.Maximum = 63;
            this.toolStripProgressBarSumAbs.Name = "toolStripProgressBarSumAbs";
            this.toolStripProgressBarSumAbs.Size = new System.Drawing.Size(100, 17);
            this.toolStripProgressBarSumAbs.Visible = false;
            // 
            // toolStripStatusLabelSumAbs
            // 
            this.toolStripStatusLabelSumAbs.Name = "toolStripStatusLabelSumAbs";
            this.toolStripStatusLabelSumAbs.Size = new System.Drawing.Size(53, 19);
            this.toolStripStatusLabelSumAbs.Text = "Sum: 0";
            this.toolStripStatusLabelSumAbs.Visible = false;
            // 
            // toolStripProgressBarTime
            // 
            this.toolStripProgressBarTime.Maximum = 10;
            this.toolStripProgressBarTime.Name = "toolStripProgressBarTime";
            this.toolStripProgressBarTime.Size = new System.Drawing.Size(100, 17);
            this.toolStripProgressBarTime.Visible = false;
            // 
            // toolStripStatusTime
            // 
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            this.toolStripStatusTime.Size = new System.Drawing.Size(138, 19);
            this.toolStripStatusTime.Text = "Time Remaining: 0s";
            this.toolStripStatusTime.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxEquation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxActions, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 175);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBoxEquation
            // 
            this.groupBoxEquation.Controls.Add(this.pause_lbl);
            this.groupBoxEquation.Controls.Add(this.equation);
            this.groupBoxEquation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEquation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEquation.Name = "groupBoxEquation";
            this.groupBoxEquation.Size = new System.Drawing.Size(766, 81);
            this.groupBoxEquation.TabIndex = 0;
            this.groupBoxEquation.TabStop = false;
            this.groupBoxEquation.Text = "Equation";
            // 
            // pause_lbl
            // 
            this.pause_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pause_lbl.Location = new System.Drawing.Point(3, 18);
            this.pause_lbl.Name = "pause_lbl";
            this.pause_lbl.Size = new System.Drawing.Size(760, 60);
            this.pause_lbl.TabIndex = 1;
            this.pause_lbl.Text = "Game Paused";
            this.pause_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pause_lbl.Visible = false;
            // 
            // equation
            // 
            this.equation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equation.ExtendedFeaturesToggle = false;
            this.equation.Location = new System.Drawing.Point(3, 18);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(760, 60);
            this.equation.TabIndex = 0;
            this.equation.SelectedItemsChanged += new NumberGamePlus.Components.Equation.SelectedItemsChangedHandle(this.equation_SelectedItemsChanged);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActions.Location = new System.Drawing.Point(3, 90);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(766, 82);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.help_btn, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.reset_btn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.submit_btn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(760, 61);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // help_btn
            // 
            this.help_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.help_btn.Location = new System.Drawing.Point(466, 10);
            this.help_btn.Margin = new System.Windows.Forms.Padding(10);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(132, 41);
            this.help_btn.TabIndex = 2;
            this.help_btn.Text = "&Help";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset_btn.ForeColor = System.Drawing.Color.Red;
            this.reset_btn.Location = new System.Drawing.Point(314, 10);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(10);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(132, 41);
            this.reset_btn.TabIndex = 1;
            this.reset_btn.Text = "&Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submit_btn.ForeColor = System.Drawing.Color.Green;
            this.submit_btn.Location = new System.Drawing.Point(10, 10);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(10);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(284, 41);
            this.submit_btn.TabIndex = 0;
            this.submit_btn.Text = "Refre&sh";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.select_all_cbx, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.pause_cbx, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(611, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(146, 55);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // select_all_cbx
            // 
            this.select_all_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select_all_cbx.Location = new System.Drawing.Point(3, 30);
            this.select_all_cbx.Name = "select_all_cbx";
            this.select_all_cbx.Size = new System.Drawing.Size(140, 22);
            this.select_all_cbx.TabIndex = 1;
            this.select_all_cbx.Text = "S&elect All";
            this.select_all_cbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.select_all_cbx.UseVisualStyleBackColor = true;
            this.select_all_cbx.Click += new System.EventHandler(this.select_all_cbx_Click);
            // 
            // pause_cbx
            // 
            this.pause_cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pause_cbx.Location = new System.Drawing.Point(3, 3);
            this.pause_cbx.Name = "pause_cbx";
            this.pause_cbx.Size = new System.Drawing.Size(140, 21);
            this.pause_cbx.TabIndex = 0;
            this.pause_cbx.Text = "&Pause";
            this.pause_cbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pause_cbx.UseVisualStyleBackColor = true;
            this.pause_cbx.CheckedChanged += new System.EventHandler(this.pause_cbx_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxTiming, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(781, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(189, 175);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBoxTiming
            // 
            this.groupBoxTiming.Controls.Add(this.timing_lbl);
            this.groupBoxTiming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTiming.Location = new System.Drawing.Point(3, 108);
            this.groupBoxTiming.Name = "groupBoxTiming";
            this.groupBoxTiming.Size = new System.Drawing.Size(183, 64);
            this.groupBoxTiming.TabIndex = 1;
            this.groupBoxTiming.TabStop = false;
            this.groupBoxTiming.Text = "Timing";
            // 
            // timing_lbl
            // 
            this.timing_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timing_lbl.Location = new System.Drawing.Point(3, 18);
            this.timing_lbl.Name = "timing_lbl";
            this.timing_lbl.Size = new System.Drawing.Size(177, 43);
            this.timing_lbl.TabIndex = 0;
            this.timing_lbl.Text = "0:00";
            this.timing_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBoxHelp, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBoxScore, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(183, 99);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Controls.Add(this.help_time_lbl);
            this.groupBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxHelp.Location = new System.Drawing.Point(94, 3);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(86, 93);
            this.groupBoxHelp.TabIndex = 1;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Help Used Time";
            // 
            // help_time_lbl
            // 
            this.help_time_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.help_time_lbl.Location = new System.Drawing.Point(3, 18);
            this.help_time_lbl.Name = "help_time_lbl";
            this.help_time_lbl.Size = new System.Drawing.Size(80, 72);
            this.help_time_lbl.TabIndex = 0;
            this.help_time_lbl.Text = "0";
            this.help_time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.score_lbl);
            this.groupBoxScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxScore.Location = new System.Drawing.Point(3, 3);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(85, 93);
            this.groupBoxScore.TabIndex = 0;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Score";
            // 
            // score_lbl
            // 
            this.score_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score_lbl.Location = new System.Drawing.Point(3, 18);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(79, 72);
            this.score_lbl.TabIndex = 0;
            this.score_lbl.Text = "0";
            this.score_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxEquation.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxTiming.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBoxHelp.ResumeLayout(false);
            this.groupBoxScore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Equation equation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxEquation;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox pause_cbx;
        private System.Windows.Forms.CheckBox select_all_cbx;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.Label pause_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarSumAbs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSumAbs;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
        private System.Windows.Forms.ToolStripStatusLabel byToolStripStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxTiming;
        private System.Windows.Forms.Label timing_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.Label help_time_lbl;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.ToolStripMenuItem showSumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timingToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxTiming;
        private System.Windows.Forms.ToolStripMenuItem bSoDWhenLoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendedFeaturesToggleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howtoplayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelExtFea;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBSoD;
        private System.Windows.Forms.ToolStripMenuItem resetFontToolStripMenuItem;
    }
}