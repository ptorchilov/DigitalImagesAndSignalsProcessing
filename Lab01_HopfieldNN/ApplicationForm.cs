namespace Lab01_HopfieldNN
{
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
            var noizeLevel = numericUpDownNoise.Value;

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

        }
    }
}
