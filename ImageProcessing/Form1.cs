using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.Model;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        ImageAdjustment ia;
        AlgorithmLbph al;
        public Form1()
        {
            InitializeComponent();
            EnableCheckBoxes(false);
            ia = new ImageAdjustment();
            al = new AlgorithmLbph();
            numericUpDownContrast.Enabled = false;
            numericUpDownRadius.Enabled = false;
            buttonStartAlgorithmLbph.Enabled = false;
        }
        private void EnableCheckBoxes(bool isEnable)
        {
            checkBoxGrayScale.Enabled = isEnable;
            checkBoxAdjustContrast.Enabled = isEnable;
            checkBoxLinearGradient.Enabled = isEnable;
            checkBoxAlgorithmLbph.Enabled = isEnable;
        }

        private void UpdatePictureBoxAfter()
        {
            pictureBoxAfter.Image = ia.ProcessedImage;
            ia.SaveProcessedImageToFile("processed-image.jpg");
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap imageBefore = (Bitmap)Image.FromFile(ofd.FileName);
                    Bitmap imageAfter = (Bitmap)Image.FromFile(ofd.FileName);
                    pictureBoxBefore.Image = imageBefore;
                    pictureBoxAfter.Image = imageAfter;

                    ia.ProcessedImage = imageAfter;
                    al.ProcessedImage = imageAfter;

                    EnableCheckBoxes(true);
                }
            }
        }

        private void checkBoxGrayScale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrayScale.Checked)
            {
                ia.ConvertToGreyscale();
                UpdatePictureBoxAfter();
            }
        }

        private void checkBoxAdjustContrast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdjustContrast.Checked)
            {
                numericUpDownContrast.Enabled = true;
            }
            else
            {
                numericUpDownContrast.Enabled = false;
            }
        }

        private void numericUpDownContrast_ValueChanged(object sender, EventArgs e)
        {
            int contrastValue = Convert.ToInt32(numericUpDownContrast.Value);
            ia.AdjustContrast(contrastValue);

            UpdatePictureBoxAfter();
        }

        Point[] mouseClicks = new Point[2];
        bool toogleClicks = true;
        private void pictureBoxBefore_MouseClick(object sender, MouseEventArgs e)
        {
            var clientSize = pictureBoxBefore.ClientSize;
            if (checkBoxLinearGradient.Checked)
            {
                if (toogleClicks)
                {
                    mouseClicks[0] = e.Location;
                    toogleClicks = false;
                }
                else
                {
                    mouseClicks[1] = e.Location;
                    toogleClicks = true;
                    ia.AddLinearGradient(mouseClicks[0], mouseClicks[1], clientSize);
                    UpdatePictureBoxAfter();
                }
            }
        }

        private void checkBoxAlgorithmLbph_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlgorithmLbph.Checked)
            {
                numericUpDownRadius.Enabled = true;
                buttonStartAlgorithmLbph.Enabled = true;
            } else
            {
                numericUpDownRadius.Enabled = false;
                buttonStartAlgorithmLbph.Enabled = false;
            }
        }

        private void buttonStartAlgorithmLbph_Click(object sender, EventArgs e)
        {
            int radiusValue = Convert.ToInt32(numericUpDownRadius.Value);
            al.Lbph(radiusValue);
            UpdatePictureBoxAfter();
        }
    }
}
