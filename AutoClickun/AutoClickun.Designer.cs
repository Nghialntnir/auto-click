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
            this.chkRandomOffsetSleep = new System.Windows.Forms.CheckBox();
            this.numOffsetSleep = new System.Windows.Forms.NumericUpDown();
            this.lblExplainSleep = new System.Windows.Forms.Label();
            this.chkRandomOffsetXY = new System.Windows.Forms.CheckBox();
            this.numOffsetXY = new System.Windows.Forms.NumericUpDown();
            this.lblExplainXY = new System.Windows.Forms.Label();
            this.grpClickOptions = new System.Windows.Forms.GroupBox();
            this.numClickCount = new System.Windows.Forms.NumericUpDown();
            this.lblMouseBtn = new System.Windows.Forms.Label();
            this.cmbMouseBtn = new System.Windows.Forms.ComboBox();
            this.lblClickCount = new System.Windows.Forms.Label();
            this.grpRepeat = new System.Windows.Forms.GroupBox();
            this.rdbRepeatTimes = new System.Windows.Forms.RadioButton();
            this.numRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.rdbRepeatUntilStopped = new System.Windows.Forms.RadioButton();
            this.grpCursor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumAwait = new System.Windows.Forms.TextBox();
            this.rdbCurrentLoc = new System.Windows.Forms.RadioButton();
            this.rdbPickLoc = new System.Windows.Forms.RadioButton();
            this.btnPickLocation = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.grpScript = new System.Windows.Forms.GroupBox();
            this.btnDeleteALine = new System.Windows.Forms.Button();
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.btnSelectScript = new System.Windows.Forms.Button();
            this.btnClearScript = new System.Windows.Forms.Button();
            this.btnSaveScript = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.grpInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetXY)).BeginInit();
            this.grpClickOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClickCount)).BeginInit();
            this.grpRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTimes)).BeginInit();
            this.grpCursor.SuspendLayout();
            this.grpScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInterval
            // 
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
            // chkRandomOffsetSleep
            // 
            this.chkRandomOffsetSleep.Checked = true;
            this.chkRandomOffsetSleep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomOffsetSleep.Location = new System.Drawing.Point(24, 35);
            this.chkRandomOffsetSleep.Margin = new System.Windows.Forms.Padding(4);
            this.chkRandomOffsetSleep.Name = "chkRandomOffsetSleep";
            this.chkRandomOffsetSleep.Size = new System.Drawing.Size(193, 21);
            this.chkRandomOffsetSleep.TabIndex = 8;
            this.chkRandomOffsetSleep.Text = "Random sleep offset +-";
            // 
            // numOffsetSleep
            // 
            this.numOffsetSleep.Location = new System.Drawing.Point(264, 34);
            this.numOffsetSleep.Margin = new System.Windows.Forms.Padding(4);
            this.numOffsetSleep.Name = "numOffsetSleep";
            this.numOffsetSleep.Size = new System.Drawing.Size(67, 22);
            this.numOffsetSleep.TabIndex = 9;
            this.numOffsetSleep.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblExplainSleep
            // 
            this.lblExplainSleep.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblExplainSleep.ForeColor = System.Drawing.Color.DimGray;
            this.lblExplainSleep.Location = new System.Drawing.Point(17, 64);
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
            this.chkRandomOffsetXY.Location = new System.Drawing.Point(24, 111);
            this.chkRandomOffsetXY.Margin = new System.Windows.Forms.Padding(4);
            this.chkRandomOffsetXY.Name = "chkRandomOffsetXY";
            this.chkRandomOffsetXY.Size = new System.Drawing.Size(227, 25);
            this.chkRandomOffsetXY.TabIndex = 11;
            this.chkRandomOffsetXY.Text = "Random coordinate offset +-";
            // 
            // numOffsetXY
            // 
            this.numOffsetXY.Location = new System.Drawing.Point(264, 111);
            this.numOffsetXY.Margin = new System.Windows.Forms.Padding(4);
            this.numOffsetXY.Name = "numOffsetXY";
            this.numOffsetXY.Size = new System.Drawing.Size(67, 22);
            this.numOffsetXY.TabIndex = 12;
            this.numOffsetXY.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblExplainXY
            // 
            this.lblExplainXY.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblExplainXY.ForeColor = System.Drawing.Color.DimGray;
            this.lblExplainXY.Location = new System.Drawing.Point(17, 143);
            this.lblExplainXY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExplainXY.Name = "lblExplainXY";
            this.lblExplainXY.Size = new System.Drawing.Size(573, 18);
            this.lblExplainXY.TabIndex = 13;
            this.lblExplainXY.Text = "(Dịch vị trí X,Y ngẫu nhiên quanh mục tiêu để tránh bị quét tọa độ cố định)";
            // 
            // grpClickOptions
            // 
            this.grpClickOptions.Controls.Add(this.numClickCount);
            this.grpClickOptions.Controls.Add(this.lblMouseBtn);
            this.grpClickOptions.Controls.Add(this.cmbMouseBtn);
            this.grpClickOptions.Controls.Add(this.lblClickCount);
            this.grpClickOptions.Location = new System.Drawing.Point(16, 228);
            this.grpClickOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpClickOptions.Name = "grpClickOptions";
            this.grpClickOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpClickOptions.Size = new System.Drawing.Size(300, 131);
            this.grpClickOptions.TabIndex = 1;
            this.grpClickOptions.TabStop = false;
            this.grpClickOptions.Text = "Click options";
            // 
            // numClickCount
            // 
            this.numClickCount.Location = new System.Drawing.Point(127, 60);
            this.numClickCount.Margin = new System.Windows.Forms.Padding(4);
            this.numClickCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClickCount.Name = "numClickCount";
            this.numClickCount.Size = new System.Drawing.Size(152, 22);
            this.numClickCount.TabIndex = 3;
            this.numClickCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // lblClickCount
            // 
            this.lblClickCount.Location = new System.Drawing.Point(16, 60);
            this.lblClickCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClickCount.Name = "lblClickCount";
            this.lblClickCount.Size = new System.Drawing.Size(94, 22);
            this.lblClickCount.TabIndex = 2;
            this.lblClickCount.Text = "Click Count:";
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
            this.grpRepeat.Size = new System.Drawing.Size(300, 131);
            this.grpRepeat.TabIndex = 2;
            this.grpRepeat.TabStop = false;
            this.grpRepeat.Text = "Click repeat";
            // 
            // rdbRepeatTimes
            // 
            this.rdbRepeatTimes.Location = new System.Drawing.Point(20, 25);
            this.rdbRepeatTimes.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRepeatTimes.Name = "rdbRepeatTimes";
            this.rdbRepeatTimes.Size = new System.Drawing.Size(85, 24);
            this.rdbRepeatTimes.TabIndex = 0;
            this.rdbRepeatTimes.Text = "Repeat";
            // 
            // numRepeatTimes
            // 
            this.numRepeatTimes.Location = new System.Drawing.Point(113, 25);
            this.numRepeatTimes.Margin = new System.Windows.Forms.Padding(4);
            this.numRepeatTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.grpCursor.Controls.Add(this.label2);
            this.grpCursor.Controls.Add(this.btnSave);
            this.grpCursor.Controls.Add(this.label1);
            this.grpCursor.Controls.Add(this.tbNumAwait);
            this.grpCursor.Controls.Add(this.rdbCurrentLoc);
            this.grpCursor.Controls.Add(this.rdbPickLoc);
            this.grpCursor.Controls.Add(this.btnPickLocation);
            this.grpCursor.Controls.Add(this.lblX);
            this.grpCursor.Controls.Add(this.txtX);
            this.grpCursor.Controls.Add(this.lblY);
            this.grpCursor.Controls.Add(this.txtY);
            this.grpCursor.Location = new System.Drawing.Point(16, 367);
            this.grpCursor.Margin = new System.Windows.Forms.Padding(4);
            this.grpCursor.Name = "grpCursor";
            this.grpCursor.Padding = new System.Windows.Forms.Padding(4);
            this.grpCursor.Size = new System.Drawing.Size(613, 152);
            this.grpCursor.TabIndex = 3;
            this.grpCursor.TabStop = false;
            this.grpCursor.Text = "Cursor position";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(270, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "(Thời gian đợi trước khi bấm)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(478, 70);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 61);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(256, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Await (ms):";
            // 
            // tbNumAwait
            // 
            this.tbNumAwait.Location = new System.Drawing.Point(339, 73);
            this.tbNumAwait.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumAwait.Name = "tbNumAwait";
            this.tbNumAwait.Size = new System.Drawing.Size(113, 22);
            this.tbNumAwait.TabIndex = 7;
            this.tbNumAwait.Text = "1000";
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
            this.lblX.Location = new System.Drawing.Point(372, 31);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 21);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(412, 31);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(65, 22);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(493, 31);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(22, 22);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Y:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(531, 31);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(65, 22);
            this.txtY.TabIndex = 6;
            this.txtY.Text = "0";
            // 
            // grpScript
            // 
            this.grpScript.Controls.Add(this.btnDeleteALine);
            this.grpScript.Controls.Add(this.listBoxScript);
            this.grpScript.Controls.Add(this.btnSelectScript);
            this.grpScript.Controls.Add(this.btnClearScript);
            this.grpScript.Controls.Add(this.btnSaveScript);
            this.grpScript.Location = new System.Drawing.Point(647, 15);
            this.grpScript.Margin = new System.Windows.Forms.Padding(4);
            this.grpScript.Name = "grpScript";
            this.grpScript.Padding = new System.Windows.Forms.Padding(4);
            this.grpScript.Size = new System.Drawing.Size(509, 504);
            this.grpScript.TabIndex = 4;
            this.grpScript.TabStop = false;
            this.grpScript.Text = "Script Location List";
            // 
            // btnDeleteALine
            // 
            this.btnDeleteALine.Location = new System.Drawing.Point(344, 439);
            this.btnDeleteALine.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteALine.Name = "btnDeleteALine";
            this.btnDeleteALine.Size = new System.Drawing.Size(151, 57);
            this.btnDeleteALine.TabIndex = 4;
            this.btnDeleteALine.Text = "Delete a line Script";
            this.btnDeleteALine.Click += new System.EventHandler(this.btnDeleteALine_Click_1);
            // 
            // listBoxScript
            // 
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.ItemHeight = 16;
            this.listBoxScript.Location = new System.Drawing.Point(16, 27);
            this.listBoxScript.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.Size = new System.Drawing.Size(485, 404);
            this.listBoxScript.TabIndex = 0;
            // 
            // btnSelectScript
            // 
            this.btnSelectScript.Location = new System.Drawing.Point(233, 439);
            this.btnSelectScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectScript.Name = "btnSelectScript";
            this.btnSelectScript.Size = new System.Drawing.Size(95, 57);
            this.btnSelectScript.TabIndex = 3;
            this.btnSelectScript.Text = "Select Script";
            this.btnSelectScript.Click += new System.EventHandler(this.btnSelectScript_Click);
            // 
            // btnClearScript
            // 
            this.btnClearScript.Location = new System.Drawing.Point(16, 439);
            this.btnClearScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(95, 57);
            this.btnClearScript.TabIndex = 1;
            this.btnClearScript.Text = "Clear Script";
            this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
            // 
            // btnSaveScript
            // 
            this.btnSaveScript.Location = new System.Drawing.Point(122, 439);
            this.btnSaveScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveScript.Name = "btnSaveScript";
            this.btnSaveScript.Size = new System.Drawing.Size(95, 57);
            this.btnSaveScript.TabIndex = 2;
            this.btnSaveScript.Text = "Save Script";
            this.btnSaveScript.Click += new System.EventHandler(this.btnSaveScript_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Green;
            this.btnStartStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(13, 527);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(1143, 55);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.Text = "START (Enter)";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // AutoClickun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 613);
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
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetXY)).EndInit();
            this.grpClickOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numClickCount)).EndInit();
            this.grpRepeat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTimes)).EndInit();
            this.grpCursor.ResumeLayout(false);
            this.grpCursor.PerformLayout();
            this.grpScript.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpInterval;
        private System.Windows.Forms.CheckBox chkRandomOffsetSleep;
        private System.Windows.Forms.NumericUpDown numOffsetSleep;
        private System.Windows.Forms.Label lblExplainSleep;
        private System.Windows.Forms.CheckBox chkRandomOffsetXY;
        private System.Windows.Forms.NumericUpDown numOffsetXY;
        private System.Windows.Forms.Label lblExplainXY;
        private System.Windows.Forms.GroupBox grpClickOptions;
        private System.Windows.Forms.Label lblMouseBtn;
        private System.Windows.Forms.ComboBox cmbMouseBtn;
        private System.Windows.Forms.Label lblClickCount;
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
        private System.Windows.Forms.TextBox tbNumAwait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectScript;
        private System.Windows.Forms.Button btnSaveScript;
        private System.Windows.Forms.Button btnDeleteALine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numClickCount;
    }
}