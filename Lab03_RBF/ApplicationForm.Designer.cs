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
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.groupBoxSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSources
            // 
            this.groupBoxSources.Controls.Add(this.pictureBoxB);
            this.groupBoxSources.Controls.Add(this.pictureBoxC);
            this.groupBoxSources.Controls.Add(this.pictureBoxA);
            this.groupBoxSources.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSources.Name = "groupBoxSources";
            this.groupBoxSources.Size = new System.Drawing.Size(919, 337);
            this.groupBoxSources.TabIndex = 0;
            this.groupBoxSources.TabStop = false;
            this.groupBoxSources.Text = "Sources";
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.Location = new System.Drawing.Point(7, 20);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxA.TabIndex = 0;
            this.pictureBoxA.TabStop = false;
            this.pictureBoxA.ImageLocation = PicturesPath.PathToOriginalA + "1.bmp";
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.Location = new System.Drawing.Point(663, 20);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxC.TabIndex = 1;
            this.pictureBoxC.TabStop = false;
            this.pictureBoxC.ImageLocation = PicturesPath.PathToOriginalC + "1.bmp";
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Location = new System.Drawing.Point(328, 20);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxB.TabIndex = 2;
            this.pictureBoxB.TabStop = false;
            this.pictureBoxB.ImageLocation = PicturesPath.PathToOriginalB + "1.bmp";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.groupBoxSources);
            this.Name = "ApplicationForm";
            this.Text = "Lab 03 - RBF";
            this.groupBoxSources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSources;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxC;
    }
}

