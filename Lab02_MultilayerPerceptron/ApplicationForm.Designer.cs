namespace Lab02_MultilayerPerceptron
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
            this.groupBoxSources = new System.Windows.Forms.GroupBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.groupBoxNoise = new System.Windows.Forms.GroupBox();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.pictureBoxNoise = new System.Windows.Forms.PictureBox();
            this.numericUpDownPercentage = new System.Windows.Forms.NumericUpDown();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.textBoxStatistics = new System.Windows.Forms.TextBox();
            this.buttonTeach = new System.Windows.Forms.Button();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.groupBoxSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            this.groupBoxNoise.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSources
            // 
            this.groupBoxSources.Controls.Add(this.pictureBoxB);
            this.groupBoxSources.Controls.Add(this.pictureBoxC);
            this.groupBoxSources.Controls.Add(this.pictureBoxA);
            this.groupBoxSources.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSources.Name = "groupBoxSources";
            this.groupBoxSources.Size = new System.Drawing.Size(919, 312);
            this.groupBoxSources.TabIndex = 0;
            this.groupBoxSources.TabStop = false;
            this.groupBoxSources.Text = "Sources";
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxB.ImageLocation = "D:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\10\\B\\B1.bmp";
            this.pictureBoxB.Location = new System.Drawing.Point(338, 20);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxB.TabIndex = 2;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxC.ImageLocation = "D:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\10\\C\\C1.bmp";
            this.pictureBoxC.Location = new System.Drawing.Point(650, 19);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxC.TabIndex = 1;
            this.pictureBoxC.TabStop = false;
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxA.ImageLocation = "D:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\10\\A\\A1.bmp";
            this.pictureBoxA.Location = new System.Drawing.Point(19, 20);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA.TabIndex = 0;
            this.pictureBoxA.TabStop = false;
            // 
            // groupBoxNoise
            // 
            this.groupBoxNoise.Controls.Add(this.buttonNoise);
            this.groupBoxNoise.Controls.Add(this.numericUpDownPercentage);
            this.groupBoxNoise.Controls.Add(this.pictureBoxNoise);
            this.groupBoxNoise.Location = new System.Drawing.Point(13, 342);
            this.groupBoxNoise.Name = "groupBoxNoise";
            this.groupBoxNoise.Size = new System.Drawing.Size(437, 328);
            this.groupBoxNoise.TabIndex = 1;
            this.groupBoxNoise.TabStop = false;
            this.groupBoxNoise.Text = "Noise";
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.labelC);
            this.groupBoxStatistics.Controls.Add(this.textBoxC);
            this.groupBoxStatistics.Controls.Add(this.labelB);
            this.groupBoxStatistics.Controls.Add(this.textBoxB);
            this.groupBoxStatistics.Controls.Add(this.labelA);
            this.groupBoxStatistics.Controls.Add(this.textBoxA);
            this.groupBoxStatistics.Controls.Add(this.buttonRecognize);
            this.groupBoxStatistics.Controls.Add(this.buttonTeach);
            this.groupBoxStatistics.Controls.Add(this.textBoxStatistics);
            this.groupBoxStatistics.Location = new System.Drawing.Point(476, 342);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(456, 328);
            this.groupBoxStatistics.TabIndex = 2;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Staticstics";
            // 
            // pictureBoxNoise
            // 
            this.pictureBoxNoise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxNoise.Location = new System.Drawing.Point(19, 42);
            this.pictureBoxNoise.Name = "pictureBoxNoise";
            this.pictureBoxNoise.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxNoise.TabIndex = 0;
            this.pictureBoxNoise.TabStop = false;
            // 
            // numericUpDownPercentage
            // 
            this.numericUpDownPercentage.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPercentage.Location = new System.Drawing.Point(290, 219);
            this.numericUpDownPercentage.Name = "numericUpDownPercentage";
            this.numericUpDownPercentage.Size = new System.Drawing.Size(129, 20);
            this.numericUpDownPercentage.TabIndex = 1;
            // 
            // buttonNoise
            // 
            this.buttonNoise.Location = new System.Drawing.Point(290, 256);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(129, 36);
            this.buttonNoise.TabIndex = 2;
            this.buttonNoise.Text = "Generate";
            this.buttonNoise.UseVisualStyleBackColor = true;
            // 
            // textBoxStatistics
            // 
            this.textBoxStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStatistics.Location = new System.Drawing.Point(20, 42);
            this.textBoxStatistics.Multiline = true;
            this.textBoxStatistics.Name = "textBoxStatistics";
            this.textBoxStatistics.ReadOnly = true;
            this.textBoxStatistics.Size = new System.Drawing.Size(300, 217);
            this.textBoxStatistics.TabIndex = 0;
            // 
            // buttonTeach
            // 
            this.buttonTeach.Location = new System.Drawing.Point(339, 42);
            this.buttonTeach.Name = "buttonTeach";
            this.buttonTeach.Size = new System.Drawing.Size(98, 36);
            this.buttonTeach.TabIndex = 1;
            this.buttonTeach.Text = "Teach";
            this.buttonTeach.UseVisualStyleBackColor = true;
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Location = new System.Drawing.Point(339, 219);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(98, 40);
            this.buttonRecognize.TabIndex = 2;
            this.buttonRecognize.Text = "Recognize";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            // 
            // textBoxA
            // 
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxA.Location = new System.Drawing.Point(32, 284);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(56, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(51, 268);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(14, 13);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(158, 268);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "B";
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Location = new System.Drawing.Point(139, 284);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(56, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(264, 268);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(14, 13);
            this.labelC.TabIndex = 8;
            this.labelC.Text = "C";
            // 
            // textBoxC
            // 
            this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxC.Location = new System.Drawing.Point(245, 284);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(56, 20);
            this.textBoxC.TabIndex = 7;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxNoise);
            this.Controls.Add(this.groupBoxSources);
            this.MaximizeBox = false;
            this.Name = "ApplicationForm";
            this.Text = "Lab 02 - Multilayer Perceptron";
            this.groupBoxSources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            this.groupBoxNoise.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSources;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxC;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.GroupBox groupBoxNoise;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.PictureBox pictureBoxNoise;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentage;
        private System.Windows.Forms.Button buttonNoise;
        private System.Windows.Forms.TextBox textBoxStatistics;
        private System.Windows.Forms.Button buttonTeach;
        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
    }
}

