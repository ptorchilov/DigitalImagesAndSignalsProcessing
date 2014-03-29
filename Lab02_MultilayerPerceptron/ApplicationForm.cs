namespace Lab02_MultilayerPerceptron
{
    using System.IO;
    using System;
    using System.Windows.Forms;
    using Lab01_HopfieldNN;

    public partial class ApplicationForm : Form
    {
        /// <summary>
        /// The picture path
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonNoiseClick(object sender, EventArgs e)
        {
            this.DeletePreveousFile(NoiseGenerator.PicturePath);

            var noiseLevel = numericUpDownPercentage.Value;

            if (radioButtonA.Checked)
            {
                picturePath = PicturesPath.PathToOriginalA + "1.bmp";
            }
            else if (radioButtonB.Checked)
            {
                picturePath = PicturesPath.PathToOriginalB + "1.bmp";
            }
            else if (radioButtonC.Checked)
            {
                picturePath = PicturesPath.PathToOriginalC + "1.bmp";
            }

            var noisePicture = NoiseGenerator.Generate(picturePath, (int) noiseLevel, 10);

            picturePath = noisePicture;

            pictureBoxNoise.ImageLocation = noisePicture;
            textBoxStatistics.Text += @"Picture with " + noiseLevel + @"% has been generated." + Environment.NewLine;
            this.ScrollTextBox();
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
                    textBoxStatistics.Text += @"Previous picture has been deleted." + Environment.NewLine;
                    ScrollTextBox();
                }
            }
        }

        /// <summary>
        /// Scrolls the text box.
        /// </summary>
        private void ScrollTextBox()
        {
            textBoxStatistics.SelectionStart = textBoxStatistics.Text.Length;
            textBoxStatistics.ScrollToCaret();
            textBoxStatistics.Refresh();
        }

        /// <summary>
        /// Buttons the teach click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonTeachClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Applications the form form closing.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void ApplicationFormFormClosing(object sender, FormClosingEventArgs e)
        {
            DeletePreveousFile(NoiseGenerator.PicturePath);
        }
    }
}
