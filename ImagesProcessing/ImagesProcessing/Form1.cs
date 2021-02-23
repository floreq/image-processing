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
using ImagesProcessingModel;

namespace ImagesProcessing
{
    public partial class Form1 : Form
    {
        static ProcessedImages pi = new ProcessedImages();
        static DetectTarget dt = new DetectTarget("haarcascade_frontalface_alt_tree.xml");
        static ImageCorections ic = new ImageCorections();
        static AlgorithmLbph al = new AlgorithmLbph();
        static string procededImagesSavePath = @"./";

        private event Action OnDetect;
        private event Action OnCorection;
        private event Action OnResize;
        private event Action OnCompare;

        public void Start()
        {
            OnCorection?.Invoke();
            OnDetect?.Invoke();
            OnResize?.Invoke();
            OnCompare?.Invoke();
            pi.Save(procededImagesSavePath);

        }
        private void Detect()
        {
            foreach (var item in pi.Images)
            {
                var cropedToFace = dt.Crop(item.Image);
                item.Image = cropedToFace;
            }
        }
        private void Contrast()
        {
            foreach (var item in pi.Images)
            {
                ic.Contrast(item, Decimal.ToInt32(numericUpDownAdjustContrast.Value));
            }
        }
        private void Gamma()
        {
            foreach (var item in pi.Images)
            {
                ic.Gamma(item, Decimal.ToSingle(numericUpDownGammaCorection.Value));
            }
        }
        private void Saturation()
        {
            foreach (var item in pi.Images)
            {
                ic.Saturation(item, Decimal.ToInt32(numericUpDownSaturation.Value));
            }
        }
        private void Lbph()
        {
            foreach (var item in pi.Images)
            {
                al.Lbph(Decimal.ToInt32(numericUpDownLbphRadius.Value), item.Image);
            }
        }
        private void Resize()
        {
            var newSize = new Size(Decimal.ToInt32(numericUpDownWidth.Value), Decimal.ToInt32(numericUpDownHeight.Value));
            foreach (var item in pi.Images)
            {
                ic.Resize(item, newSize);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, Filter = "Files|*.jpg;*.gif;*.png" })
            {
                if (ofd.ShowDialog() is DialogResult.OK)
                {
                    pi = new ProcessedImages();
                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        var image = new Bitmap(ofd.FileNames[i]);
                        var imageName = ofd.SafeFileNames[i];

                        pi.Add(new ProcessedImage(image, imageName));
                    }
                    textBoxImages.Text = string.Join("; ", ofd.SafeFileNames);
                }
            }
        }

        private void buttonProcessedImagesPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() is DialogResult.OK)
                {
                    var path = fbd.SelectedPath;
                    procededImagesSavePath = path;
                    textBoxProcessedImagesPath.Text = path;
                }

            }
        }

        private void buttonStartProcessing_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void radioButtonDetectTarget_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDetectTarget.Checked) OnDetect += Detect;
        }

        private void radioButtonNotDetectTarget_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNotDetectTarget.Checked) OnDetect -= Detect;
        }

        private void checkBoxAdjustConstrast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdjustConstrast.Checked)
            {
                OnCorection += Contrast;
            }
            else
            {
                OnCorection -= Contrast;
            }
        }
        
        private void checkBoxGammaCorection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGammaCorection.Checked)
            {
                OnCorection += Gamma;
            }
            else
            {
                OnCorection -= Gamma;
            }
        }

        private void checkBoxSaturation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaturation.Checked)
            {
                OnCorection += Saturation;
            }
            else
            {
                OnCorection -= Saturation;
            }
        }

        private void checkBoxRezieImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRezieImage.Checked)
            {
                OnResize += Resize;
            }
            else
            {
                OnResize -= Resize;
            }
        }

        private void checkBoxLBPH_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLBPH.Checked)
            {
                OnCompare += Lbph;
            }
            else
            {
                OnCompare -= Lbph;
            }
        }
    }
}
