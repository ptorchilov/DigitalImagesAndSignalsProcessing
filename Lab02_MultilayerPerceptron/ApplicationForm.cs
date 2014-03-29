namespace Lab02_MultilayerPerceptron
{
    using System.Globalization;
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
        /// The helper
        /// </summary>
        private PerceptronHelper helper;

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
                picturePath = PicturesPath.PathToOriginalA;
            }
            else if (radioButtonB.Checked)
            {
                picturePath = PicturesPath.PathToOriginalB;
            }
            else if (radioButtonC.Checked)
            {
                picturePath = PicturesPath.PathToOriginalC;
            }

            var noisePicture = NoiseGenerator.Generate(picturePath, (int)noiseLevel, 10);

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
            var container = this.GetVectorContainer(
                PicturesPath.PathToOriginalA,
                PicturesPath.PathToOriginalB,
                PicturesPath.PathToOriginalC,
                new NeuronHelper());

            var perceptron = new Perceptron(
                double.Parse(textBoxAlpha.Text),
                double.Parse(textBoxBeta.Text),
                double.Parse(textBoxError.Text),
                int.Parse(textBoxTimeout.Text),
                container);

            helper = new PerceptronHelper(perceptron, 100, 3);

            textBoxStatistics.Text += @"Network has been teached." + Environment.NewLine;
            textBoxStatistics.Text += @"Number of iterations: " + helper.NumberOfIterations + Environment.NewLine;

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
        /// Gets the vector container.
        /// </summary>
        /// <param name="pathA">The path aggregate.</param>
        /// <param name="pathB">The path attribute.</param>
        /// <param name="pathC">The path asynchronous.</param>
        /// <param name="neuronHelper">The helper.</param>
        /// <returns></returns>
        private VectorsContainer GetVectorContainer(String pathA, String pathB, String pathC, NeuronHelper neuronHelper)
        {
            var vectorA = neuronHelper.ConvertToVector(new PictureContainer(pathA, 10));
            var vectorB = neuronHelper.ConvertToVector(new PictureContainer(pathB, 10));
            var vectorC = neuronHelper.ConvertToVector(new PictureContainer(pathC, 10));

            return new VectorsContainer(vectorA, vectorB, vectorC);
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

            var vector = neuronHelper.ConvertToVector(new PictureContainer(picturePath, 10));

            var percentage = helper.Recognize(vector);

            textBoxA.Text = percentage[0].ToString(CultureInfo.InvariantCulture);
            textBoxB.Text = percentage[1].ToString(CultureInfo.InvariantCulture);
            textBoxC.Text = percentage[2].ToString(CultureInfo.InvariantCulture);
        }
    }
}