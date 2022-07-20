namespace SecureTransferMI
{
    partial class S_7_ImageRanking {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bOpenFile = new System.Windows.Forms.Button();
            this.tImageFile = new System.Windows.Forms.TextBox();
            this.nSegmentWidth = new System.Windows.Forms.NumericUpDown();
            this.lSegmentSize = new System.Windows.Forms.Label();
            this.lAlgorithm = new System.Windows.Forms.Label();
            this.cAlgorithm = new System.Windows.Forms.ComboBox();
            this.cMetric = new System.Windows.Forms.ComboBox();
            this.lMetric = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.cSampling = new System.Windows.Forms.ComboBox();
            this.lSampling = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.bSave = new System.Windows.Forms.Button();
            this.bRevert = new System.Windows.Forms.Button();
            this.cOrder = new System.Windows.Forms.ComboBox();
            this.lOrder = new System.Windows.Forms.Label();
            this.lImageSize = new System.Windows.Forms.Label();
            this.nSegmentHeight = new System.Windows.Forms.NumericUpDown();
            this.tbThreshold = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bProcess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nSegmentWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSegmentHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bOpenFile
            // 
            this.bOpenFile.Location = new System.Drawing.Point(-3, 19);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(85, 23);
            this.bOpenFile.TabIndex = 0;
            this.bOpenFile.Text = "Open image...";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // tImageFile
            // 
            this.tImageFile.Location = new System.Drawing.Point(-3, 48);
            this.tImageFile.Name = "tImageFile";
            this.tImageFile.ReadOnly = true;
            this.tImageFile.Size = new System.Drawing.Size(203, 20);
            this.tImageFile.TabIndex = 2;
            // 
            // nSegmentWidth
            // 
            this.nSegmentWidth.Location = new System.Drawing.Point(73, 228);
            this.nSegmentWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nSegmentWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSegmentWidth.Name = "nSegmentWidth";
            this.nSegmentWidth.Size = new System.Drawing.Size(50, 20);
            this.nSegmentWidth.TabIndex = 14;
            this.nSegmentWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lSegmentSize
            // 
            this.lSegmentSize.AutoSize = true;
            this.lSegmentSize.Location = new System.Drawing.Point(-3, 230);
            this.lSegmentSize.Name = "lSegmentSize";
            this.lSegmentSize.Size = new System.Drawing.Size(70, 13);
            this.lSegmentSize.TabIndex = 13;
            this.lSegmentSize.Text = "Segment size";
            this.lSegmentSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lAlgorithm
            // 
            this.lAlgorithm.AutoSize = true;
            this.lAlgorithm.Location = new System.Drawing.Point(17, 124);
            this.lAlgorithm.Name = "lAlgorithm";
            this.lAlgorithm.Size = new System.Drawing.Size(50, 13);
            this.lAlgorithm.TabIndex = 5;
            this.lAlgorithm.Text = "Algorithm";
            this.lAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cAlgorithm
            // 
            this.cAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cAlgorithm.FormattingEnabled = true;
            this.cAlgorithm.Items.AddRange(new object[] {
            "WholeImage",
            "Row",
            "Column",
            "Segment"});
            this.cAlgorithm.Location = new System.Drawing.Point(73, 121);
            this.cAlgorithm.Name = "cAlgorithm";
            this.cAlgorithm.Size = new System.Drawing.Size(127, 21);
            this.cAlgorithm.TabIndex = 6;
            this.cAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cAlgorithm_SelectedIndexChanged);
            // 
            // cMetric
            // 
            this.cMetric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMetric.FormattingEnabled = true;
            this.cMetric.Items.AddRange(new object[] {
            "Intensity",
            "Lightness",
            "Value",
            "Luma",
            "Hue (HSL)",
            "Hue (Lab)",
            "Chroma (HSL)",
            "Chroma (Lab)",
            "Saturation (HSB)",
            "Saturation (HSI)",
            "Saturation (HSL)",
            "Saturation (Lab)",
            "RedChannel",
            "GreenChannel",
            "BlueChannel",
            "Red",
            "Green",
            "Blue",
            "Cyan",
            "Magenta",
            "Yellow",
            "a (Lab)",
            "b (Lab)"});
            this.cMetric.Location = new System.Drawing.Point(73, 174);
            this.cMetric.Name = "cMetric";
            this.cMetric.Size = new System.Drawing.Size(127, 21);
            this.cMetric.TabIndex = 10;
            // 
            // lMetric
            // 
            this.lMetric.AutoSize = true;
            this.lMetric.Location = new System.Drawing.Point(31, 177);
            this.lMetric.Name = "lMetric";
            this.lMetric.Size = new System.Drawing.Size(36, 13);
            this.lMetric.TabIndex = 9;
            this.lMetric.Text = "Metric";
            this.lMetric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Location = new System.Drawing.Point(126, 232);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(12, 13);
            this.lX.TabIndex = 15;
            this.lX.Text = "x";
            this.lX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cSampling
            // 
            this.cSampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSampling.FormattingEnabled = true;
            this.cSampling.Items.AddRange(new object[] {
            "Center",
            "Average (Mean)",
            "Average (Median)",
            "Maximum",
            "Minimum",
            "Random"});
            this.cSampling.Location = new System.Drawing.Point(73, 201);
            this.cSampling.Name = "cSampling";
            this.cSampling.Size = new System.Drawing.Size(127, 21);
            this.cSampling.TabIndex = 12;
            // 
            // lSampling
            // 
            this.lSampling.AutoSize = true;
            this.lSampling.Location = new System.Drawing.Point(17, 204);
            this.lSampling.Name = "lSampling";
            this.lSampling.Size = new System.Drawing.Size(50, 13);
            this.lSampling.TabIndex = 11;
            this.lSampling.Text = "Sampling";
            this.lSampling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbProgress.Location = new System.Drawing.Point(31, 380);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(224, 23);
            this.pbProgress.TabIndex = 18;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(108, 74);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(92, 23);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save image...";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bRevert
            // 
            this.bRevert.Location = new System.Drawing.Point(108, 19);
            this.bRevert.Name = "bRevert";
            this.bRevert.Size = new System.Drawing.Size(92, 23);
            this.bRevert.TabIndex = 1;
            this.bRevert.Text = "Show Original";
            this.bRevert.UseVisualStyleBackColor = true;
            this.bRevert.Click += new System.EventHandler(this.bRevert_Click);
            // 
            // cOrder
            // 
            this.cOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOrder.FormattingEnabled = true;
            this.cOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending",
            "Ascending Reflected",
            "Descending Reflected",
            "Ascending Thresholded",
            "Descending Thresholded",
            "Random"});
            this.cOrder.Location = new System.Drawing.Point(73, 148);
            this.cOrder.Name = "cOrder";
            this.cOrder.Size = new System.Drawing.Size(127, 21);
            this.cOrder.TabIndex = 8;
            // 
            // lOrder
            // 
            this.lOrder.AutoSize = true;
            this.lOrder.Location = new System.Drawing.Point(34, 151);
            this.lOrder.Name = "lOrder";
            this.lOrder.Size = new System.Drawing.Size(33, 13);
            this.lOrder.TabIndex = 7;
            this.lOrder.Text = "Order";
            this.lOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lImageSize
            // 
            this.lImageSize.AutoSize = true;
            this.lImageSize.Location = new System.Drawing.Point(24, 79);
            this.lImageSize.Name = "lImageSize";
            this.lImageSize.Size = new System.Drawing.Size(58, 13);
            this.lImageSize.TabIndex = 3;
            this.lImageSize.Text = "lImageSize";
            // 
            // nSegmentHeight
            // 
            this.nSegmentHeight.Location = new System.Drawing.Point(144, 230);
            this.nSegmentHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nSegmentHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSegmentHeight.Name = "nSegmentHeight";
            this.nSegmentHeight.Size = new System.Drawing.Size(50, 20);
            this.nSegmentHeight.TabIndex = 16;
            this.nSegmentHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // tbThreshold
            // 
            this.tbThreshold.LargeChange = 10;
            this.tbThreshold.Location = new System.Drawing.Point(73, 254);
            this.tbThreshold.Maximum = 99;
            this.tbThreshold.Minimum = 1;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(127, 45);
            this.tbThreshold.TabIndex = 21;
            this.tbThreshold.TickFrequency = 10;
            this.tbThreshold.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Threshold";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRevert);
            this.groupBox1.Controls.Add(this.nSegmentHeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bOpenFile);
            this.groupBox1.Controls.Add(this.tbThreshold);
            this.groupBox1.Controls.Add(this.tImageFile);
            this.groupBox1.Controls.Add(this.lX);
            this.groupBox1.Controls.Add(this.nSegmentWidth);
            this.groupBox1.Controls.Add(this.lSegmentSize);
            this.groupBox1.Controls.Add(this.lImageSize);
            this.groupBox1.Controls.Add(this.lAlgorithm);
            this.groupBox1.Controls.Add(this.cOrder);
            this.groupBox1.Controls.Add(this.cAlgorithm);
            this.groupBox1.Controls.Add(this.lOrder);
            this.groupBox1.Controls.Add(this.lMetric);
            this.groupBox1.Controls.Add(this.cMetric);
            this.groupBox1.Controls.Add(this.bSave);
            this.groupBox1.Controls.Add(this.lSampling);
            this.groupBox1.Controls.Add(this.cSampling);
            this.groupBox1.Location = new System.Drawing.Point(709, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 335);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 42F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(182)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(2, -9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 74);
            this.label3.TabIndex = 102;
            this.label3.Text = "Image Reorder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.label5.Location = new System.Drawing.Point(28, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Secret Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.label2.Location = new System.Drawing.Point(263, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Image Reorder";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.button2.Image = global::SecureTransferMI.Properties.Resources.right_circular;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(28, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 54);
            this.button2.TabIndex = 109;
            this.button2.Text = "Proceed";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.button3.Image = global::SecureTransferMI.Properties.Resources.line;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(28, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 50);
            this.button3.TabIndex = 107;
            this.button3.Text = "Image Reorder";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.bRandomize_Click);
            // 
            // bProcess
            // 
            this.bProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.bProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.bProcess.Image = global::SecureTransferMI.Properties.Resources.thumbs_up;
            this.bProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bProcess.Location = new System.Drawing.Point(28, 315);
            this.bProcess.Name = "bProcess";
            this.bProcess.Size = new System.Drawing.Size(227, 55);
            this.bProcess.TabIndex = 19;
            this.bProcess.Text = "Process";
            this.bProcess.UseVisualStyleBackColor = false;
            this.bProcess.Visible = false;
            this.bProcess.Click += new System.EventHandler(this.bProcess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(261, 98);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(434, 368);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // S_7_ImageRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(707, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bProcess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "S_7_ImageRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelSorter";
            ((System.ComponentModel.ISupportInitialize)(this.nSegmentWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSegmentHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.TextBox tImageFile;
        private System.Windows.Forms.NumericUpDown nSegmentWidth;
        private System.Windows.Forms.Label lSegmentSize;
        private System.Windows.Forms.Label lAlgorithm;
        private System.Windows.Forms.ComboBox cAlgorithm;
        private System.Windows.Forms.ComboBox cMetric;
        private System.Windows.Forms.Label lMetric;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.ComboBox cSampling;
        private System.Windows.Forms.Label lSampling;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Button bProcess;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bRevert;
        private System.Windows.Forms.ComboBox cOrder;
        private System.Windows.Forms.Label lOrder;
        private System.Windows.Forms.Label lImageSize;
        private System.Windows.Forms.NumericUpDown nSegmentHeight;
        private System.Windows.Forms.TrackBar tbThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

