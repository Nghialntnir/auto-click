namespace AutoClickun
{
    partial class AutoClickun
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
            this.grpInterval = new System.Windows.Forms.GroupBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.lblMins = new System.Windows.Forms.Label();
            this.numMins = new System.Windows.Forms.NumericUpDown();
            this.lblSecs = new System.Windows.Forms.Label();
            this.numSecs = new System.Windows.Forms.NumericUpDown();
            this.lblMilli = new System.Windows.Forms.Label();
            this.numMilli = new System.Windows.Forms.NumericUpDown();
            this.chkRandomOffsetSleep = new System.Windows.Forms.CheckBox();
            this.numOffsetSleep = new System.Windows.Forms.NumericUpDown();
            this.lblExplainSleep = new System.Windows.Forms.Label();
            this.chkRandomOffsetXY = new System.Windows.Forms.CheckBox();
            this.numOffsetXY = new System.Windows.Forms.NumericUpDown();
            this.lblExplainXY = new System.Windows.Forms.Label();
            this.grpClickOptions = new System.Windows.Forms.GroupBox();
            this.lblMouseBtn = new System.Windows.Forms.Label();
            this.cmbMouseBtn = new System.Windows.Forms.ComboBox();
            this.lblClickType = new System.Windows.Forms.Label();
            this.cmbClickType = new System.Windows.Forms.ComboBox();
            this.grpRepeat = new System.Windows.Forms.GroupBox();
            this.rdbRepeatTimes = new System.Windows.Forms.RadioButton();
            this.numRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.rdbRepeatUntilStopped = new System.Windows.Forms.RadioButton();
            this.grpCursor = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbCurrentLoc = new System.Windows.Forms.RadioButton();
            this.rdbPickLoc = new System.Windows.Forms.RadioButton();
            this.btnPickLocation = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.grpScript = new System.Windows.Forms.GroupBox();
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.btnClearScript = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.grpInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMilli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetXY)).BeginInit();
            this.grpClickOptions.SuspendLayout();
            this.grpRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTimes)).BeginInit();
            this.grpCursor.SuspendLayout();
            this.grpScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInterval
            // 
            this.grpInterval.Controls.Add(this.lblHours);
            this.grpInterval.Controls.Add(this.numHours);
            this.grpInterval.Controls.Add(this.lblMins);
            this.grpInterval.Controls.Add(this.numMins);
            this.grpInterval.Controls.Add(this.lblSecs);
            this.grpInterval.Controls.Add(this.numSecs);
            this.grpInterval.Controls.Add(this.lblMilli);
            this.grpInterval.Controls.Add(this.numMilli);
            this.grpInterval.Controls.Add(this.chkRandomOffsetSleep);
            this.grpInterval.Controls.Add(this.numOffsetSleep);
            this.grpInterval.Controls.Add(this.lblExplainSleep);
            this.grpInterval.Controls.Add(this.chkRandomOffsetXY);
            this.grpInterval.Controls.Add(this.numOffsetXY);
            this.grpInterval.Controls.Add(this.lblExplainXY);
            this.grpInterval.Location = new System.Drawing.Point(16, 15);
            this.grpInterval.Margin = new System.Windows.Forms.Padding(4);
            this.grpInterval.Name = "grpInterval";
            this.grpInterval.Padding = new System.Windows.Forms.Padding(4);
            this.grpInterval.Size = new System.Drawing.Size(613, 203);
            this.grpInterval.TabIndex = 0;
            this.grpInterval.TabStop = false;
            this.grpInterval.Text = "Click Interval & Anti-Bot Setting";
            // 
            // lblHours
            // 
            this.lblHours.Location = new System.Drawing.Point(87, 30);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(45, 19);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "hours";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(20, 27);
            this.numHours.Margin = new System.Windows.Forms.Padding(4);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(60, 22);
            this.numHours.TabIndex = 1;
            // 
            // lblMins
            // 
            this.lblMins.Location = new System.Drawing.Point(207, 30);
            this.lblMins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(40, 19);
            this.lblMins.TabIndex = 2;
            this.lblMins.Text = "mins";
            // 
            // numMins
            // 
            this.numMins.Location = new System.Drawing.Point(140, 27);
            this.numMins.Margin = new System.Windows.Forms.Padding(4);
            this.numMins.Name = "numMins";
            this.numMins.Size = new System.Drawing.Size(60, 22);
            this.numMins.TabIndex = 3;
            // 
            // lblSecs
            // 
            this.lblSecs.Location = new System.Drawing.Point(327, 30);
            this.lblSecs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(33, 19);
            this.lblSecs.TabIndex = 4;
            this.lblSecs.Text = "secs";
            // 
            // numSecs
            // 
            this.numSecs.Location = new System.Drawing.Point(260, 27);
            this.numSecs.Margin = new System.Windows.Forms.Padding(4);
            this.numSecs.Name = "numSecs";
            this.numSecs.Size = new System.Drawing.Size(60, 22);
            this.numSecs.TabIndex = 5;
            // 
            // lblMilli
            // 
            this.lblMilli.Location = new System.Drawing.Point(460, 30);
            this.lblMilli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilli.Name = "lblMilli";
            this.lblMilli.Size = new System.Drawing.Size(133, 28);
            this.lblMilli.TabIndex = 6;
            this.lblMilli.Text = "milliseconds";
            // 
            // numMilli
            // 
            this.numMilli.Location = new System.Drawing.Point(380, 27);
            this.numMilli.Margin = new System.Windows.Forms.Padding(4);
            this.numMilli.Name = "numMilli";
            this.numMilli.Size = new System.Drawing.Size(73, 22);
            this.numMilli.TabIndex = 7;
            this.numMilli.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkRandomOffsetSleep
            // 
            this.chkRandomOffsetSleep.Checked = true;
            this.chkRandomOffsetSleep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomOffsetSleep.Location = new System.Drawing.Point(20, 68);
            this.chkRandomOffsetSleep.Margin = new System.Windows.Forms.Padding(4);
            this.chkRandomOffsetSleep.Name = "chkRandomOffsetSleep";
            this.chkRandomOffsetSleep.Size = new System.Drawing.Size(193, 25);
            this.chkRandomOffsetSleep.TabIndex = 8;
            this.chkRandomOffsetSleep.Text = "Random sleep offset +-";
            // 
            // numOffsetSleep
            // 
            this.numOffsetSleep.Location = new System.Drawing.Point(220, 68);
            this.numOffsetSleep.Margin = new System.Windows.Forms.Padding(4);
            this.numOffsetSleep.Name = "numOffsetSleep";
            this.numOffsetSleep.Size = new System.Drawing.Size(67, 22);
            this.numOffsetSleep.TabIndex = 9;
            this.numOffsetSleep.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblExplainSleep
            // 
            this.lblExplainSleep.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblExplainSleep.ForeColor = System.Drawing.Color.DimGray;
            this.lblExplainSleep.Location = new System.Drawing.Point(20, 96);
            this.lblExplainSleep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExplainSleep.Name = "lblExplainSleep";
            this.lblExplainSleep.Size = new System.Drawing.Size(573, 18);
            this.lblExplainSleep.TabIndex = 10;
            this.lblExplainSleep.Text = "(Tự động cộng/trừ ngẫu nhiên vào độ trễ để nhịp bấm tự nhiên)";
            // 
            // chkRandomOffsetXY
            // 
            this.chkRandomOffsetXY.Checked = true;
            this.chkRandomOffsetXY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomOffsetXY.Location = new System.Drawing.Point(20, 129);
            this.chkRandomOffsetXY.Margin = new System.Windows.Forms.Padding(4);
            this.chkRandomOffsetXY.Name = "chkRandomOffsetXY";
            this.chkRandomOffsetXY.Size = new System.Drawing.Size(227, 25);
            this.chkRandomOffsetXY.TabIndex = 11;
            this.chkRandomOffsetXY.Text = "Random coordinate offset +-";
            // 
            // numOffsetXY
            // 
            this.numOffsetXY.Location = new System.Drawing.Point(253, 129);
            this.numOffsetXY.Margin = new System.Windows.Forms.Padding(4);
            this.numOffsetXY.Name = "numOffsetXY";
            this.numOffsetXY.Size = new System.Drawing.Size(67, 22);
            this.numOffsetXY.TabIndex = 12;
            this.numOffsetXY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblExplainXY
            // 
            this.lblExplainXY.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblExplainXY.ForeColor = System.Drawing.Color.DimGray;
            this.lblExplainXY.Location = new System.Drawing.Point(20, 158);
            this.lblExplainXY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExplainXY.Name = "lblExplainXY";
            this.lblExplainXY.Size = new System.Drawing.Size(573, 18);
            this.lblExplainXY.TabIndex = 13;
            this.lblExplainXY.Text = "(Dịch vị trí X,Y ngẫu nhiên quanh mục tiêu để tránh bị quét tọa độ cố định)";
            // 
            // grpClickOptions
            // 
            this.grpClickOptions.Controls.Add(this.lblMouseBtn);
            this.grpClickOptions.Controls.Add(this.cmbMouseBtn);
            this.grpClickOptions.Controls.Add(this.lblClickType);
            this.grpClickOptions.Controls.Add(this.cmbClickType);
            this.grpClickOptions.Location = new System.Drawing.Point(16, 228);
            this.grpClickOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpClickOptions.Name = "grpClickOptions";
            this.grpClickOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpClickOptions.Size = new System.Drawing.Size(300, 98);
            this.grpClickOptions.TabIndex = 1;
            this.grpClickOptions.TabStop = false;
            this.grpClickOptions.Text = "Click options";
            // 
            // lblMouseBtn
            // 
            this.lblMouseBtn.Location = new System.Drawing.Point(16, 27);
            this.lblMouseBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMouseBtn.Name = "lblMouseBtn";
            this.lblMouseBtn.Size = new System.Drawing.Size(94, 20);
            this.lblMouseBtn.TabIndex = 0;
            this.lblMouseBtn.Text = "Mouse button:";
            // 
            // cmbMouseBtn
            // 
            this.cmbMouseBtn.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.cmbMouseBtn.Location = new System.Drawing.Point(127, 23);
            this.cmbMouseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMouseBtn.Name = "cmbMouseBtn";
            this.cmbMouseBtn.Size = new System.Drawing.Size(152, 24);
            this.cmbMouseBtn.TabIndex = 1;
            // 
            // lblClickType
            // 
            this.lblClickType.Location = new System.Drawing.Point(16, 60);
            this.lblClickType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClickType.Name = "lblClickType";
            this.lblClickType.Size = new System.Drawing.Size(94, 22);
            this.lblClickType.TabIndex = 2;
            this.lblClickType.Text = "Click type:";
            // 
            // cmbClickType
            // 
            this.cmbClickType.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.cmbClickType.Location = new System.Drawing.Point(127, 57);
            this.cmbClickType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClickType.Name = "cmbClickType";
            this.cmbClickType.Size = new System.Drawing.Size(152, 24);
            this.cmbClickType.TabIndex = 3;
            // 
            // grpRepeat
            // 
            this.grpRepeat.Controls.Add(this.rdbRepeatTimes);
            this.grpRepeat.Controls.Add(this.numRepeatTimes);
            this.grpRepeat.Controls.Add(this.rdbRepeatUntilStopped);
            this.grpRepeat.Location = new System.Drawing.Point(329, 228);
            this.grpRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.grpRepeat.Name = "grpRepeat";
            this.grpRepeat.Padding = new System.Windows.Forms.Padding(4);
            this.grpRepeat.Size = new System.Drawing.Size(300, 98);
            this.grpRepeat.TabIndex = 2;
            this.grpRepeat.TabStop = false;
            this.grpRepeat.Text = "Click repeat";
            // 
            // rdbRepeatTimes
            // 
            this.rdbRepeatTimes.Location = new System.Drawing.Point(20, 25);
            this.rdbRepeatTimes.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRepeatTimes.Name = "rdbRepeatTimes";
            this.rdbRepeatTimes.Size = new System.Drawing.Size(120, 24);
            this.rdbRepeatTimes.TabIndex = 0;
            this.rdbRepeatTimes.Text = "Repeat";
            // 
            // numRepeatTimes
            // 
            this.numRepeatTimes.Location = new System.Drawing.Point(113, 25);
            this.numRepeatTimes.Margin = new System.Windows.Forms.Padding(4);
            this.numRepeatTimes.Name = "numRepeatTimes";
            this.numRepeatTimes.Size = new System.Drawing.Size(67, 22);
            this.numRepeatTimes.TabIndex = 1;
            this.numRepeatTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdbRepeatUntilStopped
            // 
            this.rdbRepeatUntilStopped.Checked = true;
            this.rdbRepeatUntilStopped.Location = new System.Drawing.Point(20, 57);
            this.rdbRepeatUntilStopped.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRepeatUntilStopped.Name = "rdbRepeatUntilStopped";
            this.rdbRepeatUntilStopped.Size = new System.Drawing.Size(200, 25);
            this.rdbRepeatUntilStopped.TabIndex = 2;
            this.rdbRepeatUntilStopped.TabStop = true;
            this.rdbRepeatUntilStopped.Text = "Repeat until stopped";
            // 
            // grpCursor
            // 
            this.grpCursor.Controls.Add(this.btnSave);
            this.grpCursor.Controls.Add(this.label1);
            this.grpCursor.Controls.Add(this.textBox1);
            this.grpCursor.Controls.Add(this.rdbCurrentLoc);
            this.grpCursor.Controls.Add(this.rdbPickLoc);
            this.grpCursor.Controls.Add(this.btnPickLocation);
            this.grpCursor.Controls.Add(this.lblX);
            this.grpCursor.Controls.Add(this.txtX);
            this.grpCursor.Controls.Add(this.lblY);
            this.grpCursor.Controls.Add(this.txtY);
            this.grpCursor.Location = new System.Drawing.Point(16, 336);
            this.grpCursor.Margin = new System.Windows.Forms.Padding(4);
            this.grpCursor.Name = "grpCursor";
            this.grpCursor.Padding = new System.Windows.Forms.Padding(4);
            this.grpCursor.Size = new System.Drawing.Size(613, 80);
            this.grpCursor.TabIndex = 3;
            this.grpCursor.TabStop = false;
            this.grpCursor.Text = "Cursor position";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 53);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 22);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(389, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Await (ms):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0";
            // 
            // rdbCurrentLoc
            // 
            this.rdbCurrentLoc.Checked = true;
            this.rdbCurrentLoc.Location = new System.Drawing.Point(20, 31);
            this.rdbCurrentLoc.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCurrentLoc.Name = "rdbCurrentLoc";
            this.rdbCurrentLoc.Size = new System.Drawing.Size(147, 25);
            this.rdbCurrentLoc.TabIndex = 0;
            this.rdbCurrentLoc.TabStop = true;
            this.rdbCurrentLoc.Text = "Current location";
            // 
            // rdbPickLoc
            // 
            this.rdbPickLoc.Location = new System.Drawing.Point(180, 31);
            this.rdbPickLoc.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPickLoc.Name = "rdbPickLoc";
            this.rdbPickLoc.Size = new System.Drawing.Size(27, 25);
            this.rdbPickLoc.TabIndex = 1;
            // 
            // btnPickLocation
            // 
            this.btnPickLocation.Location = new System.Drawing.Point(213, 25);
            this.btnPickLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnPickLocation.Name = "btnPickLocation";
            this.btnPickLocation.Size = new System.Drawing.Size(147, 37);
            this.btnPickLocation.TabIndex = 2;
            this.btnPickLocation.Text = "Pick location";
            this.btnPickLocation.Click += new System.EventHandler(this.btnPickLocation_Click);
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(372, 25);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 21);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(404, 23);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(65, 22);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(477, 25);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(22, 22);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Y:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(507, 23);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(65, 22);
            this.txtY.TabIndex = 6;
            this.txtY.Text = "0";
            // 
            // grpScript
            // 
            this.grpScript.Controls.Add(this.listBoxScript);
            this.grpScript.Controls.Add(this.btnClearScript);
            this.grpScript.Location = new System.Drawing.Point(647, 15);
            this.grpScript.Margin = new System.Windows.Forms.Padding(4);
            this.grpScript.Name = "grpScript";
            this.grpScript.Padding = new System.Windows.Forms.Padding(4);
            this.grpScript.Size = new System.Drawing.Size(327, 401);
            this.grpScript.TabIndex = 4;
            this.grpScript.TabStop = false;
            this.grpScript.Text = "Script Location List";
            // 
            // listBoxScript
            // 
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.ItemHeight = 16;
            this.listBoxScript.Location = new System.Drawing.Point(16, 27);
            this.listBoxScript.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.Size = new System.Drawing.Size(293, 324);
            this.listBoxScript.TabIndex = 0;
            this.listBoxScript.SelectedIndexChanged += new System.EventHandler(this.listBoxScript_SelectedIndexChanged);
            // 
            // btnClearScript
            // 
            this.btnClearScript.Location = new System.Drawing.Point(16, 359);
            this.btnClearScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(295, 34);
            this.btnClearScript.TabIndex = 1;
            this.btnClearScript.Text = "Clear Script";
            this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Green;
            this.btnStartStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(16, 431);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(957, 55);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.Text = "START (F6)";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // AutoClickun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 506);
            this.Controls.Add(this.grpInterval);
            this.Controls.Add(this.grpClickOptions);
            this.Controls.Add(this.grpRepeat);
            this.Controls.Add(this.grpCursor);
            this.Controls.Add(this.grpScript);
            this.Controls.Add(this.btnStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AutoClickun";
            this.Text = "AutoClickun";
            this.grpInterval.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMilli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetXY)).EndInit();
            this.grpClickOptions.ResumeLayout(false);
            this.grpRepeat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTimes)).EndInit();
            this.grpCursor.ResumeLayout(false);
            this.grpCursor.PerformLayout();
            this.grpScript.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpInterval;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.NumericUpDown numMins;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.NumericUpDown numSecs;
        private System.Windows.Forms.Label lblMilli;
        private System.Windows.Forms.NumericUpDown numMilli;
        private System.Windows.Forms.CheckBox chkRandomOffsetSleep;
        private System.Windows.Forms.NumericUpDown numOffsetSleep;
        private System.Windows.Forms.Label lblExplainSleep;
        private System.Windows.Forms.CheckBox chkRandomOffsetXY;
        private System.Windows.Forms.NumericUpDown numOffsetXY;
        private System.Windows.Forms.Label lblExplainXY;
        private System.Windows.Forms.GroupBox grpClickOptions;
        private System.Windows.Forms.Label lblMouseBtn;
        private System.Windows.Forms.ComboBox cmbMouseBtn;
        private System.Windows.Forms.Label lblClickType;
        private System.Windows.Forms.ComboBox cmbClickType;
        private System.Windows.Forms.GroupBox grpRepeat;
        private System.Windows.Forms.RadioButton rdbRepeatTimes;
        private System.Windows.Forms.NumericUpDown numRepeatTimes;
        private System.Windows.Forms.RadioButton rdbRepeatUntilStopped;
        private System.Windows.Forms.GroupBox grpCursor;
        private System.Windows.Forms.RadioButton rdbCurrentLoc;
        private System.Windows.Forms.RadioButton rdbPickLoc;
        private System.Windows.Forms.Button btnPickLocation;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.GroupBox grpScript;
        private System.Windows.Forms.ListBox listBoxScript;
        private System.Windows.Forms.Button btnClearScript;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}

