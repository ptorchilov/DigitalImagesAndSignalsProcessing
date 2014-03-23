namespace Lab01_HopfieldNN
{
    partial class ApplicationForm
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
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxNoise = new System.Windows.Forms.GroupBox();
            this.numericUpDownNoise = new System.Windows.Forms.NumericUpDown();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.textBoxStatistics = new System.Windows.Forms.TextBox();
            this.buttonStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            this.groupBoxSource.SuspendLayout();
            this.groupBoxNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxA.ImageLocation = "D:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\A\\A.bmp";
            this.pictureBoxA.Location = new System.Drawing.Point(17, 19);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(260, 260);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxA.TabIndex = 0;
            this.pictureBoxA.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxB.ImageLocation = "D:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\B\\B.bmp";
            this.pictureBoxB.Location = new System.Drawing.Point(337, 19);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(260, 260);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxB.TabIndex = 1;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxC.ImageLocation = "D:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\C\\C.bmp";
            this.pictureBoxC.Location = new System.Drawing.Point(644, 19);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(260, 260);
            this.pictureBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxC.TabIndex = 2;
            this.pictureBoxC.TabStop = false;
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Controls.Add(this.radioButton3);
            this.groupBoxSource.Controls.Add(this.radioButton2);
            this.groupBoxSource.Controls.Add(this.radioButton1);
            this.groupBoxSource.Controls.Add(this.pictureBoxB);
            this.groupBoxSource.Controls.Add(this.pictureBoxC);
            this.groupBoxSource.Controls.Add(this.pictureBoxA);
            this.groupBoxSource.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(920, 313);
            this.groupBoxSource.TabIndex = 3;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Sources";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(755, 285);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(438, 285);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(114, 285);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxNoise
            // 
            this.groupBoxNoise.Controls.Add(this.numericUpDownNoise);
            this.groupBoxNoise.Controls.Add(this.buttonNoise);
            this.groupBoxNoise.Controls.Add(this.pictureBox1);
            this.groupBoxNoise.Location = new System.Drawing.Point(13, 332);
            this.groupBoxNoise.Name = "groupBoxNoise";
            this.groupBoxNoise.Size = new System.Drawing.Size(409, 326);
            this.groupBoxNoise.TabIndex = 4;
            this.groupBoxNoise.TabStop = false;
            this.groupBoxNoise.Text = "Noise";
            // 
            // numericUpDownNoise
            // 
            this.numericUpDownNoise.Location = new System.Drawing.Point(283, 211);
            this.numericUpDownNoise.Name = "numericUpDownNoise";
            this.numericUpDownNoise.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNoise.TabIndex = 9;
            // 
            // buttonNoise
            // 
            this.buttonNoise.Location = new System.Drawing.Point(283, 251);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(120, 28);
            this.buttonNoise.TabIndex = 8;
            this.buttonNoise.Text = "Generate";
            this.buttonNoise.UseVisualStyleBackColor = true;
            this.buttonNoise.Click += new System.EventHandler(this.ButtonNoiseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.textBoxStatistics);
            this.groupBoxStatistics.Controls.Add(this.buttonStatistics);
            this.groupBoxStatistics.Location = new System.Drawing.Point(450, 332);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(482, 326);
            this.groupBoxStatistics.TabIndex = 5;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // textBoxStatistics
            // 
            this.textBoxStatistics.Location = new System.Drawing.Point(20, 19);
            this.textBoxStatistics.Multiline = true;
            this.textBoxStatistics.Name = "textBoxStatistics";
            this.textBoxStatistics.ReadOnly = true;
            this.textBoxStatistics.Size = new System.Drawing.Size(276, 260);
            this.textBoxStatistics.TabIndex = 1;
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(328, 251);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(128, 28);
            this.buttonStatistics.TabIndex = 0;
            this.buttonStatistics.Text = "Recognize";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxNoise);
            this.Controls.Add(this.groupBoxSource);
            this.Name = "ApplicationForm";
            this.Text = "Lab 01 - Hopfield neural network";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationFormFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.groupBoxNoise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxC;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxNoise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNoise;
        private System.Windows.Forms.NumericUpDown numericUpDownNoise;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.TextBox textBoxStatistics;
    }
}

