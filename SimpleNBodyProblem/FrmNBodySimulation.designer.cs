namespace SmallGames.NBodySimulation
{
    partial class FrmNBodySimulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNBodySimulation));
            this.btnInit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxNoOfParticals = new System.Windows.Forms.NumericUpDown();
            this.txtbxMass = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.btnShiftFrameOfReference = new System.Windows.Forms.Button();
            this.chkScreenRefresh = new System.Windows.Forms.CheckBox();
            this.btnZoomOut5x = new System.Windows.Forms.Button();
            this.btnZoomIn5x = new System.Windows.Forms.Button();
            this.btnZoomOutMax = new System.Windows.Forms.Button();
            this.btnZoomInNormal = new System.Windows.Forms.Button();
            this.tbarTimeSpeed = new System.Windows.Forms.TrackBar();
            this.lbTimeSpeed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDistribution = new System.Windows.Forms.ComboBox();
            this.distributionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInitFromPrev = new System.Windows.Forms.Button();
            this.btnExportParams = new System.Windows.Forms.Button();
            this.btnImportParams = new System.Windows.Forms.Button();
            this.chkBxPauseAtNextMerge = new System.Windows.Forms.CheckBox();
            this.convas = new System.Windows.Forms.PictureBox();
            this.lvParticlesData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadVisibleParticlesData = new System.Windows.Forms.Button();
            this.txtbxUnivHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxUnivWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxDensity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtbxNoOfParticals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTimeSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distributionBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxUnivHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxUnivWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(105, 167);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(38, 23);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No of Particals";
            // 
            // txtbxNoOfParticals
            // 
            this.txtbxNoOfParticals.Location = new System.Drawing.Point(94, 10);
            this.txtbxNoOfParticals.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtbxNoOfParticals.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtbxNoOfParticals.Name = "txtbxNoOfParticals";
            this.txtbxNoOfParticals.Size = new System.Drawing.Size(130, 20);
            this.txtbxNoOfParticals.TabIndex = 3;
            this.txtbxNoOfParticals.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtbxMass
            // 
            this.txtbxMass.Location = new System.Drawing.Point(94, 36);
            this.txtbxMass.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtbxMass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtbxMass.Name = "txtbxMass";
            this.txtbxMass.Size = new System.Drawing.Size(130, 20);
            this.txtbxMass.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtbxMass, "Mass in Kg of each particle");
            this.txtbxMass.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unit Mass";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(149, 167);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 6;
            this.btnStartStop.Text = "Start / Stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time Speed";
            // 
            // refresher
            // 
            this.refresher.Interval = 50;
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // btnShiftFrameOfReference
            // 
            this.btnShiftFrameOfReference.Location = new System.Drawing.Point(833, 306);
            this.btnShiftFrameOfReference.Name = "btnShiftFrameOfReference";
            this.btnShiftFrameOfReference.Size = new System.Drawing.Size(213, 23);
            this.btnShiftFrameOfReference.TabIndex = 13;
            this.btnShiftFrameOfReference.Text = "Shift Frame of Reference to Biggest Object";
            this.btnShiftFrameOfReference.UseVisualStyleBackColor = true;
            this.btnShiftFrameOfReference.Click += new System.EventHandler(this.btnShiftFrameOfReference_Click);
            // 
            // chkScreenRefresh
            // 
            this.chkScreenRefresh.AutoSize = true;
            this.chkScreenRefresh.Checked = true;
            this.chkScreenRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScreenRefresh.Location = new System.Drawing.Point(13, 325);
            this.chkScreenRefresh.Name = "chkScreenRefresh";
            this.chkScreenRefresh.Size = new System.Drawing.Size(130, 17);
            this.chkScreenRefresh.TabIndex = 14;
            this.chkScreenRefresh.Text = "Enble Screen Refresh";
            this.chkScreenRefresh.UseVisualStyleBackColor = true;
            this.chkScreenRefresh.CheckedChanged += new System.EventHandler(this.chkScreenRefresh_CheckedChanged);
            // 
            // btnZoomOut5x
            // 
            this.btnZoomOut5x.Location = new System.Drawing.Point(739, 302);
            this.btnZoomOut5x.Name = "btnZoomOut5x";
            this.btnZoomOut5x.Size = new System.Drawing.Size(91, 23);
            this.btnZoomOut5x.TabIndex = 16;
            this.btnZoomOut5x.Text = "Zoom out 2x";
            this.btnZoomOut5x.UseVisualStyleBackColor = true;
            this.btnZoomOut5x.Click += new System.EventHandler(this.btnZoomOut5x_Click);
            // 
            // btnZoomIn5x
            // 
            this.btnZoomIn5x.Location = new System.Drawing.Point(739, 331);
            this.btnZoomIn5x.Name = "btnZoomIn5x";
            this.btnZoomIn5x.Size = new System.Drawing.Size(91, 23);
            this.btnZoomIn5x.TabIndex = 17;
            this.btnZoomIn5x.Text = "Zoom in 2x";
            this.btnZoomIn5x.UseVisualStyleBackColor = true;
            this.btnZoomIn5x.Click += new System.EventHandler(this.btnZoomIn5x_Click);
            // 
            // btnZoomOutMax
            // 
            this.btnZoomOutMax.Location = new System.Drawing.Point(739, 274);
            this.btnZoomOutMax.Name = "btnZoomOutMax";
            this.btnZoomOutMax.Size = new System.Drawing.Size(88, 23);
            this.btnZoomOutMax.TabIndex = 18;
            this.btnZoomOutMax.Text = "Zoom out Max";
            this.btnZoomOutMax.UseVisualStyleBackColor = true;
            this.btnZoomOutMax.Click += new System.EventHandler(this.btnZoomOutMax_Click);
            // 
            // btnZoomInNormal
            // 
            this.btnZoomInNormal.Location = new System.Drawing.Point(742, 360);
            this.btnZoomInNormal.Name = "btnZoomInNormal";
            this.btnZoomInNormal.Size = new System.Drawing.Size(88, 23);
            this.btnZoomInNormal.TabIndex = 19;
            this.btnZoomInNormal.Text = "Zoom Normal";
            this.btnZoomInNormal.UseVisualStyleBackColor = true;
            this.btnZoomInNormal.Click += new System.EventHandler(this.btnZoomInNormal_Click);
            // 
            // tbarTimeSpeed
            // 
            this.tbarTimeSpeed.LargeChange = 2;
            this.tbarTimeSpeed.Location = new System.Drawing.Point(23, 25);
            this.tbarTimeSpeed.Maximum = 22;
            this.tbarTimeSpeed.Minimum = 1;
            this.tbarTimeSpeed.Name = "tbarTimeSpeed";
            this.tbarTimeSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarTimeSpeed.Size = new System.Drawing.Size(45, 197);
            this.tbarTimeSpeed.TabIndex = 20;
            this.tbarTimeSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarTimeSpeed.Value = 1;
            this.tbarTimeSpeed.Scroll += new System.EventHandler(this.tbarTimeSpeed_Scroll);
            // 
            // lbTimeSpeed
            // 
            this.lbTimeSpeed.Location = new System.Drawing.Point(23, 226);
            this.lbTimeSpeed.Name = "lbTimeSpeed";
            this.lbTimeSpeed.Size = new System.Drawing.Size(45, 13);
            this.lbTimeSpeed.TabIndex = 21;
            this.lbTimeSpeed.Text = "2";
            this.lbTimeSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTimeSpeed);
            this.panel1.Controls.Add(this.tbarTimeSpeed);
            this.panel1.Location = new System.Drawing.Point(736, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 255);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Distribution";
            // 
            // cmbDistribution
            // 
            this.cmbDistribution.DataSource = this.distributionBindingSource;
            this.cmbDistribution.DisplayMember = "Name";
            this.cmbDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistribution.FormattingEnabled = true;
            this.cmbDistribution.Location = new System.Drawing.Point(94, 140);
            this.cmbDistribution.Name = "cmbDistribution";
            this.cmbDistribution.Size = new System.Drawing.Size(130, 21);
            this.cmbDistribution.TabIndex = 24;
            this.cmbDistribution.ValueMember = "Code";
            // 
            // distributionBindingSource
            // 
            this.distributionBindingSource.DataSource = typeof(SmallGames.Distribution);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(16, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 156);
            this.panel2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 338);
            this.label7.TabIndex = 0;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // btnInitFromPrev
            // 
            this.btnInitFromPrev.Location = new System.Drawing.Point(12, 167);
            this.btnInitFromPrev.Name = "btnInitFromPrev";
            this.btnInitFromPrev.Size = new System.Drawing.Size(87, 23);
            this.btnInitFromPrev.TabIndex = 26;
            this.btnInitFromPrev.Text = "Init From Prev";
            this.btnInitFromPrev.UseVisualStyleBackColor = true;
            this.btnInitFromPrev.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnExportParams
            // 
            this.btnExportParams.Location = new System.Drawing.Point(15, 196);
            this.btnExportParams.Name = "btnExportParams";
            this.btnExportParams.Size = new System.Drawing.Size(84, 23);
            this.btnExportParams.TabIndex = 27;
            this.btnExportParams.Text = "Export Params";
            this.btnExportParams.UseVisualStyleBackColor = true;
            this.btnExportParams.Click += new System.EventHandler(this.btnExportParams_Click);
            // 
            // btnImportParams
            // 
            this.btnImportParams.Location = new System.Drawing.Point(105, 196);
            this.btnImportParams.Name = "btnImportParams";
            this.btnImportParams.Size = new System.Drawing.Size(84, 23);
            this.btnImportParams.TabIndex = 28;
            this.btnImportParams.Text = "Import Params";
            this.btnImportParams.UseVisualStyleBackColor = true;
            this.btnImportParams.Click += new System.EventHandler(this.btnImportParams_Click);
            // 
            // chkBxPauseAtNextMerge
            // 
            this.chkBxPauseAtNextMerge.AutoSize = true;
            this.chkBxPauseAtNextMerge.Location = new System.Drawing.Point(11, 302);
            this.chkBxPauseAtNextMerge.Name = "chkBxPauseAtNextMerge";
            this.chkBxPauseAtNextMerge.Size = new System.Drawing.Size(126, 17);
            this.chkBxPauseAtNextMerge.TabIndex = 29;
            this.chkBxPauseAtNextMerge.Text = "Pause at Next Merge";
            this.chkBxPauseAtNextMerge.UseVisualStyleBackColor = true;
            this.chkBxPauseAtNextMerge.CheckedChanged += new System.EventHandler(this.chkBxPauseAtNextMerge_CheckedChanged);
            // 
            // convas
            // 
            this.convas.BackColor = System.Drawing.Color.Black;
            this.convas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convas.Location = new System.Drawing.Point(233, 10);
            this.convas.Name = "convas";
            this.convas.Size = new System.Drawing.Size(500, 500);
            this.convas.TabIndex = 30;
            this.convas.TabStop = false;
            this.convas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.convas_MouseClick);
            this.convas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.convas_MouseDoubleClick);
            // 
            // lvParticlesData
            // 
            this.lvParticlesData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvParticlesData.FullRowSelect = true;
            this.lvParticlesData.GridLines = true;
            this.lvParticlesData.HideSelection = false;
            this.lvParticlesData.Location = new System.Drawing.Point(833, 13);
            this.lvParticlesData.Name = "lvParticlesData";
            this.lvParticlesData.Size = new System.Drawing.Size(295, 255);
            this.lvParticlesData.TabIndex = 31;
            this.lvParticlesData.UseCompatibleStateImageBehavior = false;
            this.lvParticlesData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Speed";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mass";
            this.columnHeader3.Width = 62;
            // 
            // btnLoadVisibleParticlesData
            // 
            this.btnLoadVisibleParticlesData.Location = new System.Drawing.Point(833, 277);
            this.btnLoadVisibleParticlesData.Name = "btnLoadVisibleParticlesData";
            this.btnLoadVisibleParticlesData.Size = new System.Drawing.Size(213, 23);
            this.btnLoadVisibleParticlesData.TabIndex = 32;
            this.btnLoadVisibleParticlesData.Text = "Load Visible Particles Data";
            this.btnLoadVisibleParticlesData.UseVisualStyleBackColor = true;
            this.btnLoadVisibleParticlesData.Click += new System.EventHandler(this.btnLoadVisibleParticlesData_Click);
            // 
            // txtbxUnivHeight
            // 
            this.txtbxUnivHeight.Location = new System.Drawing.Point(94, 88);
            this.txtbxUnivHeight.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtbxUnivHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtbxUnivHeight.Name = "txtbxUnivHeight";
            this.txtbxUnivHeight.Size = new System.Drawing.Size(130, 20);
            this.txtbxUnivHeight.TabIndex = 36;
            this.txtbxUnivHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Univ Height";
            // 
            // txtbxUnivWidth
            // 
            this.txtbxUnivWidth.Location = new System.Drawing.Point(94, 62);
            this.txtbxUnivWidth.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtbxUnivWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtbxUnivWidth.Name = "txtbxUnivWidth";
            this.txtbxUnivWidth.Size = new System.Drawing.Size(130, 20);
            this.txtbxUnivWidth.TabIndex = 34;
            this.txtbxUnivWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Univ Width";
            // 
            // txtbxDensity
            // 
            this.txtbxDensity.Location = new System.Drawing.Point(94, 114);
            this.txtbxDensity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtbxDensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtbxDensity.Name = "txtbxDensity";
            this.txtbxDensity.Size = new System.Drawing.Size(130, 20);
            this.txtbxDensity.TabIndex = 38;
            this.toolTip1.SetToolTip(this.txtbxDensity, "Density will determine the radius of each particle given its mass.");
            this.txtbxDensity.Value = new decimal(new int[] {
            22570,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Particle Density";
            // 
            // FrmNBodySimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 516);
            this.Controls.Add(this.txtbxDensity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxUnivHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxUnivWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoadVisibleParticlesData);
            this.Controls.Add(this.lvParticlesData);
            this.Controls.Add(this.convas);
            this.Controls.Add(this.chkBxPauseAtNextMerge);
            this.Controls.Add(this.btnImportParams);
            this.Controls.Add(this.btnExportParams);
            this.Controls.Add(this.btnInitFromPrev);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbDistribution);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnZoomInNormal);
            this.Controls.Add(this.btnZoomOutMax);
            this.Controls.Add(this.btnZoomIn5x);
            this.Controls.Add(this.btnZoomOut5x);
            this.Controls.Add(this.chkScreenRefresh);
            this.Controls.Add(this.btnShiftFrameOfReference);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.txtbxMass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxNoOfParticals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNBodySimulation";
            this.Text = "N Body Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNBodySimulation_FormClosing);
            this.Load += new System.EventHandler(this.FrmNBodySimulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtbxNoOfParticals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTimeSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distributionBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxUnivHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxUnivWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtbxNoOfParticals;
        private System.Windows.Forms.NumericUpDown txtbxMass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer refresher;
        private System.Windows.Forms.Button btnShiftFrameOfReference;
        private System.Windows.Forms.CheckBox chkScreenRefresh;
        private System.Windows.Forms.Button btnZoomOut5x;
        private System.Windows.Forms.Button btnZoomIn5x;
        private System.Windows.Forms.Button btnZoomOutMax;
        private System.Windows.Forms.Button btnZoomInNormal;
        private System.Windows.Forms.TrackBar tbarTimeSpeed;
        private System.Windows.Forms.Label lbTimeSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDistribution;
        private System.Windows.Forms.BindingSource distributionBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInitFromPrev;
        private System.Windows.Forms.Button btnExportParams;
        private System.Windows.Forms.Button btnImportParams;
        private System.Windows.Forms.CheckBox chkBxPauseAtNextMerge;
        private System.Windows.Forms.PictureBox convas;
        private System.Windows.Forms.ListView lvParticlesData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnLoadVisibleParticlesData;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown txtbxUnivHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtbxUnivWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtbxDensity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}