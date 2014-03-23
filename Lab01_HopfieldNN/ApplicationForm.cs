namespace Lab01_HopfieldNN
{
    using System.IO;
    using System.Windows.Forms;
    using System;

    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ButtonNoiseClick(object sender, System.EventArgs e)
        {
            this.DeletePreveousFile(NoiseGenerator.PicturePath);

            var noiseLevel = numericUpDownNoise.Value;

            var picturePath = String.Empty;

            if (radioButton1.Checked)
            {
                picturePath = PicturesPath.PathToOriginalA;
            }
            else if (radioButton2.Checked)
            {
                picturePath = PicturesPath.PathToOriginalB;
            }
            else
            {
                picturePath = PicturesPath.PathToOriginalC;
            }

            var noisePicture = NoiseGenerator.Generate(picturePath, (int) noiseLevel);

            pictureBox1.ImageLocation = noisePicture;
        }

        private void DeletePreveousFile(String path)
        {
            if (path != null)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }

        private void ApplicationFormFormClosing(object sender, FormClosingEventArgs e)
        {
            this.DeletePreveousFile(NoiseGenerator.PicturePath);
        }
    }
}
