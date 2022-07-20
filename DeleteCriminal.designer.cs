namespace SecureTransferMI
{
    partial class DeleteCriminal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtbrwse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btbdesc = new System.Windows.Forms.Button();
            this.picbxadd = new System.Windows.Forms.PictureBox();
            this.btbbrwse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxadd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 226);
            this.dataGridView1.TabIndex = 42;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(182)))), ((int)(((byte)(209)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 397);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(807, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 42F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(182)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(-2, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 74);
            this.label4.TabIndex = 40;
            this.label4.Text = "Delete Suspect..";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtbrwse
            // 
            this.txtbrwse.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbrwse.Location = new System.Drawing.Point(11, 125);
            this.txtbrwse.Margin = new System.Windows.Forms.Padding(4);
            this.txtbrwse.Multiline = true;
            this.txtbrwse.Name = "txtbrwse";
            this.txtbrwse.Size = new System.Drawing.Size(168, 32);
            this.txtbrwse.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(7, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Suspect ID";
            // 
            // btbdesc
            // 
            this.btbdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.btbdesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbdesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbdesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.btbdesc.Location = new System.Drawing.Point(12, 319);
            this.btbdesc.Margin = new System.Windows.Forms.Padding(4);
            this.btbdesc.Name = "btbdesc";
            this.btbdesc.Size = new System.Drawing.Size(226, 32);
            this.btbdesc.TabIndex = 35;
            this.btbdesc.Text = "Delete";
            this.btbdesc.UseVisualStyleBackColor = false;
            this.btbdesc.Click += new System.EventHandler(this.btbdesc_Click);
            // 
            // picbxadd
            // 
            this.picbxadd.Location = new System.Drawing.Point(11, 165);
            this.picbxadd.Margin = new System.Windows.Forms.Padding(4);
            this.picbxadd.Name = "picbxadd";
            this.picbxadd.Size = new System.Drawing.Size(227, 146);
            this.picbxadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxadd.TabIndex = 39;
            this.picbxadd.TabStop = false;
            // 
            // btbbrwse
            // 
            this.btbbrwse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.btbbrwse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbbrwse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbbrwse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(126)))));
            this.btbbrwse.Image = global::SecureTransferMI.Properties.Resources.search;
            this.btbbrwse.Location = new System.Drawing.Point(187, 125);
            this.btbbrwse.Margin = new System.Windows.Forms.Padding(4);
            this.btbbrwse.Name = "btbbrwse";
            this.btbbrwse.Size = new System.Drawing.Size(51, 30);
            this.btbbrwse.TabIndex = 37;
            this.btbbrwse.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btbbrwse.UseVisualStyleBackColor = false;
            this.btbbrwse.Click += new System.EventHandler(this.btbbrwse_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(3)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.button1.Location = new System.Drawing.Point(12, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 32);
            this.button1.TabIndex = 123;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picbxadd);
            this.Controls.Add(this.txtbrwse);
            this.Controls.Add(this.btbbrwse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbdesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCriminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCriminal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picbxadd;
        private System.Windows.Forms.TextBox txtbrwse;
        private System.Windows.Forms.Button btbbrwse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbdesc;
        private System.Windows.Forms.Button button1;
    }
}