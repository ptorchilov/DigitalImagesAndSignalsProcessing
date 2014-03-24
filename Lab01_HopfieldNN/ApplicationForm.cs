namespace Lab01_HopfieldNN
{
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System;
    using Properties;

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
        private void ButtonNoiseClick(object sender, EventArgs e)
        {
            DeletePreveousFile(NoiseGenerator.PicturePath);

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

            picturePath = noisePicture;

            pictureBox1.ImageLocation = noisePicture;

            textBoxStatistics.Text += @"Picture with " + noiseLevel + @"% has been generated." + Environment.NewLine;
            ScrollTextBox();
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
        /// Applications the form form closing.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void ApplicationFormFormClosing(object sender, FormClosingEventArgs e)
        {
            DeletePreveousFile(NoiseGenerator.PicturePath);
        }

        /// <summary>
        /// Buttons the statistics click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonStatisticsClick(object sender, EventArgs e)
        {
            if (picturePath == null)
            {
                MessageBox.Show(Resources.ApplicationForm_ButtonStatisticsClick_Choose_picture_);
                return;
            }

            var helper = new NeuronHelper();

            var picture = new Bitmap(picturePath);

            var vector = helper.ConvertToVector(picture);

            var network = new HopfieldNetwork();

            ChooseCorrectVector(network, vector);

            picture.Dispose();

        }

        /// <summary>
        /// Chooses the correct vector.
        /// </summary>
        /// <param name="network">The network.</param>
        /// <param name="vector">The vector.</param>
        private void ChooseCorrectVector(HopfieldNetwork network, sbyte[] vector)
        {
            network.StartRecognize(vector);

            var vectorNumber = network.CorrectVector;

            switch (vectorNumber)
            {
                case 0:
                    {
                        textBoxStatistics.Text += @"It's an A picture." + Environment.NewLine;
                        textBoxStatistics.Text += @"Number of iterations: " + network.NumberOfIterantions + Environment.NewLine;
                        ScrollTextBox();
                        break;
                    }
                case 1:
                    {
                        textBoxStatistics.Text += @"It's a B picture." + Environment.NewLine;
                        textBoxStatistics.Text += @"Number of iterations: " + network.NumberOfIterantions + Environment.NewLine;
                        ScrollTextBox();
                        break;
                    }
                case 2:
                    {
                        textBoxStatistics.Text += @"It's a C picture." + Environment.NewLine;
                        textBoxStatistics.Text += @"Number of iterations: " + network.NumberOfIterantions + Environment.NewLine;
                        ScrollTextBox();
                        break;
                    }
                default:
                    {
                        textBoxStatistics.Text += @"It's unknown picture." + Environment.NewLine;
                        textBoxStatistics.Text += @"Number of iterations: " + network.NumberOfIterantions + Environment.NewLine;
                        ScrollTextBox();
                        break;
                    }
            }
        }

        /// <summary>
        /// Buttons the teach click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonTeachClick(object sender, EventArgs e)
        {
            var helper = new NeuronHelper();

            var picture = new Bitmap(PicturesPath.PathToOriginalA);
            NeuronHelper.VectorA = helper.ConvertToVector(picture);
            var matrixA = helper.CreateMatrix(NeuronHelper.VectorA);

            picture = new Bitmap(PicturesPath.PathToOriginalB);
            NeuronHelper.VectorB = helper.ConvertToVector(picture);
            var matrixB = helper.CreateMatrix(NeuronHelper.VectorB);

            picture = new Bitmap(PicturesPath.PathToOriginalC);
            NeuronHelper.VectorC = helper.ConvertToVector(picture);
            var matrixC = helper.CreateMatrix(NeuronHelper.VectorC);

            HopfieldNetwork.MatrixW = helper.CreateCoefficientsMatrix(matrixA, matrixB, matrixC);

            textBoxStatistics.Text += @"Network has been taught." + Environment.NewLine;
            ScrollTextBox();
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
    }
}
