namespace Lab01_HopfieldNN
{
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System;

    using Lab01_HopfieldNN.Properties;

    public partial class ApplicationForm : Form
    {
        /// <summary>
        /// The original picture path
        /// </summary>
        private String picturePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationForm"/> class.
        /// </summary>
        public ApplicationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Buttons the noise click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonNoiseClick(object sender, System.EventArgs e)
        {
            this.DeletePreveousFile(NoiseGenerator.PicturePath);

            var noiseLevel = numericUpDownNoise.Value;

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

        /// <summary>
        /// Deletes the preveous file.
        /// </summary>
        /// <param name="path">The path.</param>
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

        /// <summary>
        /// Applications the form form closing.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void ApplicationFormFormClosing(object sender, FormClosingEventArgs e)
        {
            this.DeletePreveousFile(NoiseGenerator.PicturePath);
        }

        private void ButtonStatisticsClick(object sender, EventArgs e)
        {
            if (picturePath == null)
            {
                MessageBox.Show(Resources.ApplicationForm_ButtonStatisticsClick_Choose_picture_);
                return;
            }

            var picture = new Bitmap(picturePath);

            var helper = new NeuronHelper();

            var vector = helper.ConvertToVector(picture);

            var matrix = helper.CreateCoefficientMatrix(vector);

        }
    }
}
