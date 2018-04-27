namespace InvAddIn
{
    partial class CWBasketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CWBasketForm));
            this.browseBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partNumberTb = new System.Windows.Forms.TextBox();
            this.filepathTb = new System.Windows.Forms.TextBox();
            this.lengthTb = new System.Windows.Forms.TextBox();
            this.widthTb = new System.Windows.Forms.TextBox();
            this.heightTb = new System.Windows.Forms.TextBox();
            this.frameDiaTb = new System.Windows.Forms.TextBox();
            this.midFrameDiaTb = new System.Windows.Forms.TextBox();
            this.dimsGb = new System.Windows.Forms.GroupBox();
            this.midFrameSpcTb = new System.Windows.Forms.TextBox();
            this.widthCWSpcTb = new System.Windows.Forms.TextBox();
            this.lengthCWSpcTb = new System.Windows.Forms.TextBox();
            this.cwDiaTb = new System.Windows.Forms.TextBox();
            this.dimsGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(1072, 719);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(735, 748);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(200, 23);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(941, 748);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(125, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset to Defaults";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1072, 748);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 725);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filepath for Part Generation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 752);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marlin Part Number:";
            // 
            // partNumberTb
            // 
            this.partNumberTb.Location = new System.Drawing.Point(154, 749);
            this.partNumberTb.Name = "partNumberTb";
            this.partNumberTb.Size = new System.Drawing.Size(575, 20);
            this.partNumberTb.TabIndex = 6;
            this.partNumberTb.Tag = "Marlin Part Number";
            // 
            // filepathTb
            // 
            this.filepathTb.Location = new System.Drawing.Point(154, 721);
            this.filepathTb.Name = "filepathTb";
            this.filepathTb.ReadOnly = true;
            this.filepathTb.Size = new System.Drawing.Size(912, 20);
            this.filepathTb.TabIndex = 7;
            this.filepathTb.Tag = "Filepath for Generation";
            // 
            // lengthTb
            // 
            this.lengthTb.Location = new System.Drawing.Point(325, 61);
            this.lengthTb.Name = "lengthTb";
            this.lengthTb.Size = new System.Drawing.Size(50, 20);
            this.lengthTb.TabIndex = 0;
            this.lengthTb.Tag = "Length";
            this.lengthTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // widthTb
            // 
            this.widthTb.Location = new System.Drawing.Point(62, 217);
            this.widthTb.Name = "widthTb";
            this.widthTb.Size = new System.Drawing.Size(50, 20);
            this.widthTb.TabIndex = 1;
            this.widthTb.Tag = "Width";
            this.widthTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightTb
            // 
            this.heightTb.Location = new System.Drawing.Point(62, 500);
            this.heightTb.Name = "heightTb";
            this.heightTb.Size = new System.Drawing.Size(50, 20);
            this.heightTb.TabIndex = 2;
            this.heightTb.Tag = "Height";
            this.heightTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frameDiaTb
            // 
            this.frameDiaTb.Location = new System.Drawing.Point(574, 473);
            this.frameDiaTb.Name = "frameDiaTb";
            this.frameDiaTb.Size = new System.Drawing.Size(50, 20);
            this.frameDiaTb.TabIndex = 3;
            this.frameDiaTb.Tag = "Frame Wire Dia.";
            this.frameDiaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // midFrameDiaTb
            // 
            this.midFrameDiaTb.Location = new System.Drawing.Point(574, 546);
            this.midFrameDiaTb.Name = "midFrameDiaTb";
            this.midFrameDiaTb.Size = new System.Drawing.Size(50, 20);
            this.midFrameDiaTb.TabIndex = 4;
            this.midFrameDiaTb.Tag = "Mid Frame Wire Dia.";
            this.midFrameDiaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dimsGb
            // 
            this.dimsGb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dimsGb.BackgroundImage")));
            this.dimsGb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dimsGb.Controls.Add(this.cwDiaTb);
            this.dimsGb.Controls.Add(this.midFrameSpcTb);
            this.dimsGb.Controls.Add(this.widthCWSpcTb);
            this.dimsGb.Controls.Add(this.lengthCWSpcTb);
            this.dimsGb.Controls.Add(this.midFrameDiaTb);
            this.dimsGb.Controls.Add(this.frameDiaTb);
            this.dimsGb.Controls.Add(this.heightTb);
            this.dimsGb.Controls.Add(this.widthTb);
            this.dimsGb.Controls.Add(this.lengthTb);
            this.dimsGb.Location = new System.Drawing.Point(12, 9);
            this.dimsGb.Name = "dimsGb";
            this.dimsGb.Size = new System.Drawing.Size(1135, 704);
            this.dimsGb.TabIndex = 8;
            this.dimsGb.TabStop = false;
            // 
            // midFrameSpcTb
            // 
            this.midFrameSpcTb.Location = new System.Drawing.Point(994, 461);
            this.midFrameSpcTb.Name = "midFrameSpcTb";
            this.midFrameSpcTb.ReadOnly = true;
            this.midFrameSpcTb.Size = new System.Drawing.Size(50, 20);
            this.midFrameSpcTb.TabIndex = 7;
            this.midFrameSpcTb.Tag = "Mid Frame Spacing";
            this.midFrameSpcTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // widthCWSpcTb
            // 
            this.widthCWSpcTb.Location = new System.Drawing.Point(727, 626);
            this.widthCWSpcTb.Name = "widthCWSpcTb";
            this.widthCWSpcTb.Size = new System.Drawing.Size(50, 20);
            this.widthCWSpcTb.TabIndex = 6;
            this.widthCWSpcTb.Tag = "CW Width Spacing";
            this.widthCWSpcTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lengthCWSpcTb
            // 
            this.lengthCWSpcTb.Location = new System.Drawing.Point(257, 624);
            this.lengthCWSpcTb.Name = "lengthCWSpcTb";
            this.lengthCWSpcTb.Size = new System.Drawing.Size(50, 20);
            this.lengthCWSpcTb.TabIndex = 5;
            this.lengthCWSpcTb.Tag = "CW Length Spacing";
            this.lengthCWSpcTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cwDiaTb
            // 
            this.cwDiaTb.Location = new System.Drawing.Point(539, 624);
            this.cwDiaTb.Name = "cwDiaTb";
            this.cwDiaTb.Size = new System.Drawing.Size(50, 20);
            this.cwDiaTb.TabIndex = 8;
            this.cwDiaTb.Tag = "CW Dia.";
            this.cwDiaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CWBasketForm
            // 
            this.AcceptButton = this.generateBtn;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(1156, 780);
            this.ControlBox = false;
            this.Controls.Add(this.dimsGb);
            this.Controls.Add(this.filepathTb);
            this.Controls.Add(this.partNumberTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.browseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CWBasketForm";
            this.Text = "Crosswire Basket Design Template";
            this.Load += new System.EventHandler(this.CWBasketForm_Load);
            this.dimsGb.ResumeLayout(false);
            this.dimsGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partNumberTb;
        private System.Windows.Forms.TextBox filepathTb;
        private System.Windows.Forms.TextBox lengthTb;
        private System.Windows.Forms.TextBox widthTb;
        private System.Windows.Forms.TextBox heightTb;
        private System.Windows.Forms.TextBox frameDiaTb;
        private System.Windows.Forms.TextBox midFrameDiaTb;
        private System.Windows.Forms.GroupBox dimsGb;
        private System.Windows.Forms.TextBox midFrameSpcTb;
        private System.Windows.Forms.TextBox widthCWSpcTb;
        private System.Windows.Forms.TextBox lengthCWSpcTb;
        private System.Windows.Forms.TextBox cwDiaTb;
    }
}