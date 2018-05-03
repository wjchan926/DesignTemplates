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
            this.midFrameSpcLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.midFrameNumTb = new System.Windows.Forms.TextBox();
            this.cwDiaTb = new System.Windows.Forms.TextBox();
            this.widthCWSpcTb = new System.Windows.Forms.TextBox();
            this.lengthCWSpcTb = new System.Windows.Forms.TextBox();
            this.materialGb = new System.Windows.Forms.GroupBox();
            this.otherMatRb = new System.Windows.Forms.RadioButton();
            this.gsRb = new System.Windows.Forms.RadioButton();
            this.psRb = new System.Windows.Forms.RadioButton();
            this.ss316Rb = new System.Windows.Forms.RadioButton();
            this.ss304Rb = new System.Windows.Forms.RadioButton();
            this.finishGb = new System.Windows.Forms.GroupBox();
            this.otherFinishTb = new System.Windows.Forms.TextBox();
            this.otherFinishRb = new System.Windows.Forms.RadioButton();
            this.powderRb = new System.Windows.Forms.RadioButton();
            this.electroRb = new System.Windows.Forms.RadioButton();
            this.naturalRb = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.weightLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTb = new System.Windows.Forms.TextBox();
            this.dimsGb.SuspendLayout();
            this.materialGb.SuspendLayout();
            this.finishGb.SuspendLayout();
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
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(1153, 662);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(187, 50);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(1153, 718);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(106, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset to Defaults";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1265, 718);
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
            this.label2.Location = new System.Drawing.Point(1153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marlin Part Number:";
            // 
            // partNumberTb
            // 
            this.partNumberTb.Location = new System.Drawing.Point(1156, 25);
            this.partNumberTb.Name = "partNumberTb";
            this.partNumberTb.Size = new System.Drawing.Size(187, 20);
            this.partNumberTb.TabIndex = 7;
            this.partNumberTb.Tag = "Marlin Part Number";
            // 
            // filepathTb
            // 
            this.filepathTb.Location = new System.Drawing.Point(154, 721);
            this.filepathTb.Name = "filepathTb";
            this.filepathTb.ReadOnly = true;
            this.filepathTb.Size = new System.Drawing.Size(912, 20);
            this.filepathTb.TabIndex = 5;
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
            this.heightTb.TextChanged += new System.EventHandler(this.heightTb_TextChanged);
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
            this.dimsGb.BackgroundImage = global::InvAddIn.Properties.Resources.Crosswire_Basket_Template_V2;
            this.dimsGb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dimsGb.Controls.Add(this.midFrameSpcLb);
            this.dimsGb.Controls.Add(this.label3);
            this.dimsGb.Controls.Add(this.midFrameNumTb);
            this.dimsGb.Controls.Add(this.cwDiaTb);
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
            this.dimsGb.TabIndex = 5;
            this.dimsGb.TabStop = false;
            // 
            // midFrameSpcLb
            // 
            this.midFrameSpcLb.AutoSize = true;
            this.midFrameSpcLb.Location = new System.Drawing.Point(999, 465);
            this.midFrameSpcLb.Name = "midFrameSpcLb";
            this.midFrameSpcLb.Size = new System.Drawing.Size(43, 13);
            this.midFrameSpcLb.TabIndex = 10;
            this.midFrameSpcLb.Text = "MidSpc";
            this.midFrameSpcLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(965, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "No. of Middle Frame(s):";
            // 
            // midFrameNumTb
            // 
            this.midFrameNumTb.Location = new System.Drawing.Point(1000, 573);
            this.midFrameNumTb.Name = "midFrameNumTb";
            this.midFrameNumTb.Size = new System.Drawing.Size(50, 20);
            this.midFrameNumTb.TabIndex = 9;
            this.midFrameNumTb.Tag = "No. MIddle Frame(s)";
            this.midFrameNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.midFrameNumTb.TextChanged += new System.EventHandler(this.midFrameNumTb_TextChanged);
            // 
            // cwDiaTb
            // 
            this.cwDiaTb.Location = new System.Drawing.Point(539, 624);
            this.cwDiaTb.Name = "cwDiaTb";
            this.cwDiaTb.Size = new System.Drawing.Size(50, 20);
            this.cwDiaTb.TabIndex = 6;
            this.cwDiaTb.Tag = "CW Dia.";
            this.cwDiaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // widthCWSpcTb
            // 
            this.widthCWSpcTb.Location = new System.Drawing.Point(727, 626);
            this.widthCWSpcTb.Name = "widthCWSpcTb";
            this.widthCWSpcTb.Size = new System.Drawing.Size(50, 20);
            this.widthCWSpcTb.TabIndex = 7;
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
            // materialGb
            // 
            this.materialGb.Controls.Add(this.otherMatRb);
            this.materialGb.Controls.Add(this.gsRb);
            this.materialGb.Controls.Add(this.psRb);
            this.materialGb.Controls.Add(this.ss316Rb);
            this.materialGb.Controls.Add(this.ss304Rb);
            this.materialGb.Location = new System.Drawing.Point(1156, 90);
            this.materialGb.Name = "materialGb";
            this.materialGb.Size = new System.Drawing.Size(187, 141);
            this.materialGb.TabIndex = 10;
            this.materialGb.TabStop = false;
            this.materialGb.Text = "Material:";
            // 
            // otherMatRb
            // 
            this.otherMatRb.AutoSize = true;
            this.otherMatRb.Location = new System.Drawing.Point(12, 111);
            this.otherMatRb.Name = "otherMatRb";
            this.otherMatRb.Size = new System.Drawing.Size(51, 17);
            this.otherMatRb.TabIndex = 4;
            this.otherMatRb.Tag = "Generic";
            this.otherMatRb.Text = "Other";
            this.otherMatRb.UseVisualStyleBackColor = true;
            this.otherMatRb.CheckedChanged += new System.EventHandler(this.otherMatRb_CheckedChanged);
            // 
            // gsRb
            // 
            this.gsRb.AutoSize = true;
            this.gsRb.Location = new System.Drawing.Point(12, 88);
            this.gsRb.Name = "gsRb";
            this.gsRb.Size = new System.Drawing.Size(105, 17);
            this.gsRb.TabIndex = 3;
            this.gsRb.Tag = "Galvanized Steel";
            this.gsRb.Text = "Galvanized Steel";
            this.gsRb.UseVisualStyleBackColor = true;
            this.gsRb.CheckedChanged += new System.EventHandler(this.gsRb_CheckedChanged);
            // 
            // psRb
            // 
            this.psRb.AutoSize = true;
            this.psRb.Location = new System.Drawing.Point(12, 65);
            this.psRb.Name = "psRb";
            this.psRb.Size = new System.Drawing.Size(137, 17);
            this.psRb.TabIndex = 2;
            this.psRb.Tag = "1008 / 1010 PLAIN STEEL";
            this.psRb.Text = "1008 / 1010 Plain Steel";
            this.psRb.UseVisualStyleBackColor = true;
            this.psRb.CheckedChanged += new System.EventHandler(this.psRb_CheckedChanged);
            // 
            // ss316Rb
            // 
            this.ss316Rb.AutoSize = true;
            this.ss316Rb.Location = new System.Drawing.Point(12, 42);
            this.ss316Rb.Name = "ss316Rb";
            this.ss316Rb.Size = new System.Drawing.Size(115, 17);
            this.ss316Rb.TabIndex = 1;
            this.ss316Rb.Tag = "316 STAINLESS STEEL";
            this.ss316Rb.Text = "316 Stainless Steel";
            this.ss316Rb.UseVisualStyleBackColor = true;
            this.ss316Rb.CheckedChanged += new System.EventHandler(this.ss316Rb_CheckedChanged);
            // 
            // ss304Rb
            // 
            this.ss304Rb.AutoSize = true;
            this.ss304Rb.Location = new System.Drawing.Point(12, 19);
            this.ss304Rb.Name = "ss304Rb";
            this.ss304Rb.Size = new System.Drawing.Size(115, 17);
            this.ss304Rb.TabIndex = 0;
            this.ss304Rb.Tag = "304 STAINLESS STEEL";
            this.ss304Rb.Text = "304 Stainless Steel";
            this.ss304Rb.UseVisualStyleBackColor = true;
            this.ss304Rb.CheckedChanged += new System.EventHandler(this.ss304Rb_CheckedChanged);
            // 
            // finishGb
            // 
            this.finishGb.Controls.Add(this.otherFinishTb);
            this.finishGb.Controls.Add(this.otherFinishRb);
            this.finishGb.Controls.Add(this.powderRb);
            this.finishGb.Controls.Add(this.electroRb);
            this.finishGb.Controls.Add(this.naturalRb);
            this.finishGb.Location = new System.Drawing.Point(1156, 237);
            this.finishGb.Name = "finishGb";
            this.finishGb.Size = new System.Drawing.Size(187, 120);
            this.finishGb.TabIndex = 11;
            this.finishGb.TabStop = false;
            this.finishGb.Text = "Finish:";
            // 
            // otherFinishTb
            // 
            this.otherFinishTb.Enabled = false;
            this.otherFinishTb.Location = new System.Drawing.Point(63, 87);
            this.otherFinishTb.Name = "otherFinishTb";
            this.otherFinishTb.Size = new System.Drawing.Size(100, 20);
            this.otherFinishTb.TabIndex = 4;
            // 
            // otherFinishRb
            // 
            this.otherFinishRb.AutoSize = true;
            this.otherFinishRb.Location = new System.Drawing.Point(12, 88);
            this.otherFinishRb.Name = "otherFinishRb";
            this.otherFinishRb.Size = new System.Drawing.Size(54, 17);
            this.otherFinishRb.TabIndex = 3;
            this.otherFinishRb.TabStop = true;
            this.otherFinishRb.Text = "Other:";
            this.otherFinishRb.UseVisualStyleBackColor = true;
            this.otherFinishRb.CheckedChanged += new System.EventHandler(this.otherFinishRb_CheckedChanged);
            // 
            // powderRb
            // 
            this.powderRb.AutoSize = true;
            this.powderRb.Location = new System.Drawing.Point(11, 65);
            this.powderRb.Name = "powderRb";
            this.powderRb.Size = new System.Drawing.Size(98, 17);
            this.powderRb.TabIndex = 2;
            this.powderRb.TabStop = true;
            this.powderRb.Text = "Powder Coated";
            this.powderRb.UseVisualStyleBackColor = true;
            this.powderRb.CheckedChanged += new System.EventHandler(this.powderRb_CheckedChanged);
            // 
            // electroRb
            // 
            this.electroRb.AutoSize = true;
            this.electroRb.Location = new System.Drawing.Point(12, 42);
            this.electroRb.Name = "electroRb";
            this.electroRb.Size = new System.Drawing.Size(97, 17);
            this.electroRb.TabIndex = 1;
            this.electroRb.TabStop = true;
            this.electroRb.Text = "Electropolished";
            this.electroRb.UseVisualStyleBackColor = true;
            this.electroRb.CheckedChanged += new System.EventHandler(this.electroRb_CheckedChanged);
            // 
            // naturalRb
            // 
            this.naturalRb.AutoSize = true;
            this.naturalRb.Location = new System.Drawing.Point(12, 19);
            this.naturalRb.Name = "naturalRb";
            this.naturalRb.Size = new System.Drawing.Size(59, 17);
            this.naturalRb.TabIndex = 0;
            this.naturalRb.TabStop = true;
            this.naturalRb.Text = "Natural";
            this.naturalRb.UseVisualStyleBackColor = true;
            this.naturalRb.CheckedChanged += new System.EventHandler(this.naturalRb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1160, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Approximate Weight:";
            // 
            // weightLb
            // 
            this.weightLb.AutoSize = true;
            this.weightLb.Location = new System.Drawing.Point(1163, 377);
            this.weightLb.Name = "weightLb";
            this.weightLb.Size = new System.Drawing.Size(0, 13);
            this.weightLb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1153, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Part Description:";
            // 
            // descriptionTb
            // 
            this.descriptionTb.Location = new System.Drawing.Point(1156, 64);
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new System.Drawing.Size(181, 20);
            this.descriptionTb.TabIndex = 10;
            this.descriptionTb.Tag = "Description";
            // 
            // CWBasketForm
            // 
            this.AcceptButton = this.generateBtn;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(1350, 751);
            this.ControlBox = false;
            this.Controls.Add(this.descriptionTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weightLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finishGb);
            this.Controls.Add(this.materialGb);
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
            this.materialGb.ResumeLayout(false);
            this.materialGb.PerformLayout();
            this.finishGb.ResumeLayout(false);
            this.finishGb.PerformLayout();
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
        private System.Windows.Forms.TextBox widthCWSpcTb;
        private System.Windows.Forms.TextBox lengthCWSpcTb;
        private System.Windows.Forms.TextBox cwDiaTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox midFrameNumTb;
        private System.Windows.Forms.GroupBox materialGb;
        private System.Windows.Forms.RadioButton gsRb;
        private System.Windows.Forms.RadioButton psRb;
        private System.Windows.Forms.RadioButton ss316Rb;
        private System.Windows.Forms.RadioButton ss304Rb;
        private System.Windows.Forms.GroupBox finishGb;
        private System.Windows.Forms.RadioButton otherMatRb;
        private System.Windows.Forms.RadioButton otherFinishRb;
        private System.Windows.Forms.RadioButton powderRb;
        private System.Windows.Forms.RadioButton electroRb;
        private System.Windows.Forms.RadioButton naturalRb;
        private System.Windows.Forms.TextBox otherFinishTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label weightLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionTb;
        private System.Windows.Forms.Label midFrameSpcLb;
    }
}