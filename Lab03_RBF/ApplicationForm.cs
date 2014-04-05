namespace Lab03_RBF
{
    using System.Globalization;
    using System.IO;
    using Lab01_HopfieldNN;
    using System;
    using System.Windows.Forms;

    public partial class ApplicationForm : Form
    {
        private String picturePath;

        private RBFHepler helper;

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

            var noiseLevel = numericUpDown1.Value;

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
        /// Applications the form form closing.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void ApplicationFormFormClosing(object sender, FormClosingEventArgs e)
        {
            DeletePreveousFile(NoiseGenerator.PicturePath);
        }

        /// <summary>
        /// Buttons the teach click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonTeachClick(object sender, EventArgs e)
        {
            var container = GetVectorContainer(
                PicturesPath.PathToOriginalA + "1.bmp",
                PicturesPath.PathToOriginalA + "2.bmp",
                PicturesPath.PathToOriginalA + "3.bmp",
                PicturesPath.PathToOriginalB + "1.bmp",
                PicturesPath.PathToOriginalB + "2.bmp",
                PicturesPath.PathToOriginalB + "3.bmp",
                PicturesPath.PathToOriginalC + "1.bmp",
                PicturesPath.PathToOriginalC + "2.bmp",
                PicturesPath.PathToOriginalC + "3.bmp",
                new NeuronHelper()
                );

            var rbf = new RBF(
                Double.Parse(textBoxAlpha.Text),
                Double.Parse(textBoxError.Text),
                Int32.Parse(textBoxTimeout.Text),
                container);

            helper = new RBFHepler(rbf, 100, 3);

            helper.Teach();

            textBoxStatistics.Text += @"Network has been teached." + Environment.NewLine;
            textBoxStatistics.Text += @"Number of iterations: " + helper.NumberOfIterations + Environment.NewLine;
            this.ScrollTextBox();
        }

        /// <summary>
        /// Gets the vector container.
        /// </summary>
        /// <param name="pathA1">The path a1.</param>
        /// <param name="pathA2">The path a2.</param>
        /// <param name="pathA3">The path a3.</param>
        /// <param name="pathB1">The path b1.</param>
        /// <param name="pathB2">The path b2.</param>
        /// <param name="pathB3">The path b3.</param>
        /// <param name="pathC1">The path c1.</param>
        /// <param name="pathC2">The path c2.</param>
        /// <param name="pathC3">The path c3.</param>
        /// <param name="neuronHelper">The helper.</param>
        /// <returns></returns>
        private VectorsContainer GetVectorContainer(String pathA1, String pathA2, String pathA3,
                                                    String pathB1, String pathB2, String pathB3, 
                                                    String pathC1, String pathC2, String pathC3, 
                                                    NeuronHelper neuronHelper)
        {
            var vectorA1 = neuronHelper.ConvertToVector(new PictureContainer(pathA1, 10));
            var vectorA2 = neuronHelper.ConvertToVector(new PictureContainer(pathA2, 10));
            var vectorA3 = neuronHelper.ConvertToVector(new PictureContainer(pathA3, 10));
            var vectorB1 = neuronHelper.ConvertToVector(new PictureContainer(pathB1, 10));
            var vectorB2 = neuronHelper.ConvertToVector(new PictureContainer(pathB2, 10));
            var vectorB3 = neuronHelper.ConvertToVector(new PictureContainer(pathB3, 10));
            var vectorC1 = neuronHelper.ConvertToVector(new PictureContainer(pathC1, 10));
            var vectorC2 = neuronHelper.ConvertToVector(new PictureContainer(pathC2, 10));
            var vectorC3 = neuronHelper.ConvertToVector(new PictureContainer(pathC3, 10));

            return new VectorsContainer(vectorA1, vectorA2, vectorA3,
                                        vectorB1, vectorB2, vectorB3,
                                        vectorC1, vectorC2, vectorC3);
        }

        /// <summary>
        /// Buttons the recognize click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonRecognizeClick(object sender, EventArgs e)
        {
            if (helper == null)
            {
                return;
            }

            var neuronHelper = new NeuronHelper();

            var picture = new PictureContainer(picturePath, 10);

            var vector = neuronHelper.ConvertToVector(picture);

            var percentage = helper.Recognize(vector);

            textBoxA.Text = Math.Abs(percentage[0]).ToString(CultureInfo.InvariantCulture);
            textBoxB.Text = Math.Abs(percentage[1]).ToString(CultureInfo.InvariantCulture);
            textBoxC.Text = Math.Abs(percentage[2]).ToString(CultureInfo.InvariantCulture);

            picture.Picture.Dispose();
        }
    }
}
