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
        ImageAfter ip;
        public Form1()
        {
            InitializeComponent();
            EnableCheckBoxes(false);
            ip = new ImageAfter();
            numericUpDownContrast.Enabled = false;
        }
        private void EnableCheckBoxes(bool isEnable)
        {
            checkBoxGrayScale.Enabled = isEnable;
            checkBoxAdjustContrast.Enabled = isEnable;
            checkBoxLinearGradient.Enabled = isEnable;
        }

        private void UpdatePictureBoxAfter()
        {
            pictureBoxAfter.Image = ip.ProcessedImage;
            ip.SaveProcessedImageToFile("processed-image.jpg");
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

                    ip.ProcessedImage = imageAfter;

                    EnableCheckBoxes(true);
                }
            }
        }

        private void checkBoxGrayScale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrayScale.Checked)
            {
                ip.ConvertToGreyscale();
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
            ip.AdjustContrast(contrastValue);

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
                    ip.AddLinearGradient(mouseClicks[0], mouseClicks[1], clientSize);
                    UpdatePictureBoxAfter();
                }
            }
        }

        private void buttonHorizontalGradient_Click(object sender, EventArgs e)
        {
        }
    }
}
