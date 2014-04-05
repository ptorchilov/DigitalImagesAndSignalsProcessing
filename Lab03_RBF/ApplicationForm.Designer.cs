namespace Lab03_RBF
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
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.groupBoxNoise = new System.Windows.Forms.GroupBox();
            this.pictureBoxNoise = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.textBoxstatistics = new System.Windows.Forms.TextBox();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.buttonTeach = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.groupBoxSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            this.groupBoxNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSources
            // 
            this.groupBoxSources.Controls.Add(this.radioButtonC);
            this.groupBoxSources.Controls.Add(this.radioButtonB);
            this.groupBoxSources.Controls.Add(this.radioButtonA);
            this.groupBoxSources.Controls.Add(this.pictureBoxB);
            this.groupBoxSources.Controls.Add(this.pictureBoxC);
            this.groupBoxSources.Controls.Add(this.pictureBoxA);
            this.groupBoxSources.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSources.Name = "groupBoxSources";
            this.groupBoxSources.Size = new System.Drawing.Size(919, 319);
            this.groupBoxSources.TabIndex = 0;
            this.groupBoxSources.TabStop = false;
            this.groupBoxSources.Text = "Sources";
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxB.ImageLocation = "d:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\10\\B\\B1.bmp";
            this.pictureBoxB.Location = new System.Drawing.Point(328, 20);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxB.TabIndex = 2;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxC.ImageLocation = "d:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\10\\C\\C1.bmp";
            this.pictureBoxC.Location = new System.Drawing.Point(663, 20);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxC.TabIndex = 1;
            this.pictureBoxC.TabStop = false;
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxA.ImageLocation = "d:\\work\\VS\\sem8\\cosii\\DigitalImagesAndSignalsProcessing\\Pictures Sources\\original" +
                "\\10\\A\\A1.bmp";
            this.pictureBoxA.Location = new System.Drawing.Point(7, 20);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA.TabIndex = 0;
            this.pictureBoxA.TabStop = false;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(100, 288);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 3;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(429, 288);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 4;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(773, 288);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(32, 17);
            this.radioButtonC.TabIndex = 5;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // groupBoxNoise
            // 
            this.groupBoxNoise.Controls.Add(this.buttonNoise);
            this.groupBoxNoise.Controls.Add(this.numericUpDown1);
            this.groupBoxNoise.Controls.Add(this.pictureBoxNoise);
            this.groupBoxNoise.Location = new System.Drawing.Point(13, 348);
            this.groupBoxNoise.Name = "groupBoxNoise";
            this.groupBoxNoise.Size = new System.Drawing.Size(411, 322);
            this.groupBoxNoise.TabIndex = 1;
            this.groupBoxNoise.TabStop = false;
            this.groupBoxNoise.Text = "Noise";
            // 
            // pictureBoxNoise
            // 
            this.pictureBoxNoise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxNoise.Location = new System.Drawing.Point(7, 42);
            this.pictureBoxNoise.Name = "pictureBoxNoise";
            this.pictureBoxNoise.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxNoise.TabIndex = 0;
            this.pictureBoxNoise.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(274, 207);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // buttonNoise
            // 
            this.buttonNoise.Location = new System.Drawing.Point(274, 250);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(120, 42);
            this.buttonNoise.TabIndex = 2;
            this.buttonNoise.Text = "Generate";
            this.buttonNoise.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.buttonRecognize);
            this.groupBoxStatistics.Controls.Add(this.textBoxB);
            this.groupBoxStatistics.Controls.Add(this.textBoxC);
            this.groupBoxStatistics.Controls.Add(this.textBoxA);
            this.groupBoxStatistics.Controls.Add(this.buttonTeach);
            this.groupBoxStatistics.Controls.Add(this.textBoxTimeout);
            this.groupBoxStatistics.Controls.Add(this.labelTimeout);
            this.groupBoxStatistics.Controls.Add(this.textBoxError);
            this.groupBoxStatistics.Controls.Add(this.labelError);
            this.groupBoxStatistics.Controls.Add(this.textBoxAlpha);
            this.groupBoxStatistics.Controls.Add(this.labelAlpha);
            this.groupBoxStatistics.Controls.Add(this.textBoxstatistics);
            this.groupBoxStatistics.Location = new System.Drawing.Point(442, 357);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(490, 313);
            this.groupBoxStatistics.TabIndex = 2;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // textBoxstatistics
            // 
            this.textBoxstatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxstatistics.Location = new System.Drawing.Point(6, 19);
            this.textBoxstatistics.Multiline = true;
            this.textBoxstatistics.Name = "textBoxstatistics";
            this.textBoxstatistics.ReadOnly = true;
            this.textBoxstatistics.Size = new System.Drawing.Size(347, 244);
            this.textBoxstatistics.TabIndex = 0;
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(364, 33);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(33, 13);
            this.labelAlpha.TabIndex = 1;
            this.labelAlpha.Text = "alpha";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(413, 30);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(71, 20);
            this.textBoxAlpha.TabIndex = 2;
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(413, 70);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(71, 20);
            this.textBoxError.TabIndex = 4;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(364, 73);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(28, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "error";
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Location = new System.Drawing.Point(413, 108);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(71, 20);
            this.textBoxTimeout.TabIndex = 6;
            // 
            // labelTimeout
            // 
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Location = new System.Drawing.Point(364, 111);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(41, 13);
            this.labelTimeout.TabIndex = 5;
            this.labelTimeout.Text = "timeout";
            // 
            // buttonTeach
            // 
            this.buttonTeach.Location = new System.Drawing.Point(367, 152);
            this.buttonTeach.Name = "buttonTeach";
            this.buttonTeach.Size = new System.Drawing.Size(117, 44);
            this.buttonTeach.TabIndex = 7;
            this.buttonTeach.Text = "Teach";
            this.buttonTeach.UseVisualStyleBackColor = true;
            // 
            // textBoxA
            // 
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxA.Location = new System.Drawing.Point(6, 278);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 8;
            // 
            // textBoxC
            // 
            this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxC.Location = new System.Drawing.Point(253, 278);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 9;
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Location = new System.Drawing.Point(128, 278);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 10;
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Location = new System.Drawing.Point(367, 255);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(117, 43);
            this.buttonRecognize.TabIndex = 11;
            this.buttonRecognize.Text = "Recognize";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxNoise);
            this.Controls.Add(this.groupBoxSources);
            this.Name = "ApplicationForm";
            this.Text = "Lab 03 - RBF";
            this.groupBoxSources.ResumeLayout(false);
            this.groupBoxSources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            this.groupBoxNoise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSources;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxC;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.GroupBox groupBoxNoise;
        private System.Windows.Forms.PictureBox pictureBoxNoise;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonNoise;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.TextBox textBoxstatistics;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.TextBox textBoxTimeout;
        private System.Windows.Forms.Label labelTimeout;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonTeach;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Button buttonRecognize;
    }
}

