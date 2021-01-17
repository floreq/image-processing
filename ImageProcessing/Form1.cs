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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using ImageProcessor;
using System.Collections;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        ImageAdjustment ia;
        AlgorithmLbph al;
        Bitmap imageAfter;
        Bitmap ImageCompare1 = null;
        Bitmap ImageCompare2 = null;
        string CompareResult = null;
        string NameOfSavedPicture = null;
        string PathOfSavedPicture = null;
        string PathToLoadFolder = null;
        string PathForImages = null;
        string PathForCSV = null;
        Size ScaleSize = new Size(275, 350);

        public Form1()
        {
            InitializeComponent();
            ia = new ImageAdjustment();
            al = new AlgorithmLbph();
        }
        private void EnableCheckBoxes(bool isEnable)
        {
            checkBoxGrayScale.Enabled = isEnable;
            checkBoxAdjustContrast.Enabled = isEnable;
            checkBoxLinearGradient.Enabled = isEnable;
            checkBoxAlgorithmLbph.Enabled = isEnable;
            checkBoxGammaCorection.Enabled = isEnable;
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
                    imageAfter = (Bitmap)Image.FromFile(ofd.FileName);
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

                    using (Graphics g = pictureBoxBefore.CreateGraphics())
                    {
                        Pen p = new Pen(Color.Red, 2);

                        g.DrawLine(p, mouseClicks[0], mouseClicks[1]);
                    }

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
            }
            else
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

        private void ImageComparison_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageComparison.Checked)
            {
                AddImage2.Enabled = true;
                AddImage3.Enabled = true;
            }
            else
            {
                AddImage2.Enabled = false;
                AddImage3.Enabled = false;
            }
        }

        private void AddImage2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageCompare1 = (Bitmap)Image.FromFile(ofd.FileName);
                }
                StartComparisonCheck();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SavePicture(ia.ProcessedImage, NameOfSavedPicture, PathOfSavedPicture);
        }

        private void AddImage3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageCompare2 = (Bitmap)Image.FromFile(ofd.FileName);
                }
                StartComparisonCheck();
            }
        }

        private void StartComparisonCheck()
        {
            if (ImageCompare1 != null && ImageCompare2 != null)
            {
                StartComparison.Enabled = true;
            }
            else
            {
                StartComparison.Enabled = false;
            }
        }

        private void StartComparison_Click(object sender, EventArgs e)
        {
            // Preparing variables for Picture division

            int RowCount = 8;
            int ColCount = 8;

            // const string Path1 = "E:/Studia/p3/LBPH/test.jpg";
            Bitmap[,] Parts1 = new Bitmap[RowCount, ColCount];

            Bitmap[,] Parts2 = new Bitmap[RowCount, ColCount];

            // Dividing picture into Parts
            DividePicture(ImageCompare1, Parts1);
            DividePicture(ImageCompare2, Parts2);

            // Preparing variable to store grayscale of every part of picture
            int[,][] AllShades1 = new int[RowCount, ColCount][];
            int[,][] AllShades2 = new int[RowCount, ColCount][];

            // Calculating shades for every part of picture
            ArrayHistogramValues(Parts1, AllShades1, RowCount, ColCount);
            ArrayHistogramValues(Parts2, AllShades2, RowCount, ColCount);

            var Result = ComparePicturesShades(AllShades1, AllShades2, RowCount, ColCount);
            var ShadesOfPart = 0;

            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    for (int k = 0; k < 256; k++)
                    {
                        ShadesOfPart += Result[i, j][k];
                    }

                    Debug.WriteLine("Similarity scale of [{0},{1}] = {2} ", i, j, ShadesOfPart);
                    ShadesOfPart = 0;
                }
            }
            CompareResult = SimilarityScale(Result, RowCount, ColCount).ToString();
            CompareOutput.Text = "Similarity scale of images = " + CompareResult + "\nWhere 0 means that they are the same";
            Debug.WriteLine("\n\n\nSimilarity scale of images = {0} \nWhere 0 means that they are the same", SimilarityScale(Result, RowCount, ColCount));
        }

        static void DividePicture(Bitmap BitmapToDivide, Bitmap[,] BitmapsMatrix)
        {
            var HeightOfMatrix = BitmapsMatrix.GetLength(0);
            var WidthOfMatrix = BitmapsMatrix.GetLength(1);
            var Width = BitmapToDivide.Width / WidthOfMatrix;
            var Height = BitmapToDivide.Height / HeightOfMatrix;
            PixelFormat Format = BitmapToDivide.PixelFormat;

            for (int i = 0; i < HeightOfMatrix; i++)
            {
                var FixedHeight = i * Height;
                for (int j = 0; j < WidthOfMatrix; j++)
                {
                    Rectangle CloneRect = new Rectangle(j * Width, FixedHeight, Width, Height);
                    BitmapsMatrix[i, j] = BitmapToDivide.Clone(CloneRect, Format);
                }
            }
        }

        static void HistogramValues(Bitmap ToCalculate, out int[] Shades)
        {
            Shades = new int[256];
            for (int i = 0; i < ToCalculate.Width; i++)
            {
                for (int j = 0; j < ToCalculate.Height; j++)
                {
                    Color Pixel = ToCalculate.GetPixel(i, j);
                    int grayScale = (int)((Pixel.R * 0.3) + (Pixel.G * 0.59) + (Pixel.B * 0.11));
                    Shades[grayScale] += 1;
                }
            }
        }

        static void ArrayHistogramValues(Bitmap[,] BitmapMatrix, int[,][] AllShades, int RowCount, int ColCount)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    // AllShades[i, j] = new int[256];
                    HistogramValues(BitmapMatrix[i, j], out AllShades[i, j]);
                }
            }
        }

        static int[] SimilarityOfTwoParts(int[] First, int[] Second)
        {
            var Result = new int[256];
            for (int i = 0; i < 256; i++)
            {
                Result[i] = Math.Abs(First[i] - Second[i]);
            }
            return Result;
        }

        static int[,][] ComparePicturesShades(int[,][] First, int[,][] Second, int RowCount, int ColCount)
        {
            var Result = new int[RowCount, ColCount][];
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    Result[i, j] = new int[256];
                    for (int k = 0; k < 256; k++)
                    {
                        Result[i, j][k] = (int)Math.Pow(First[i, j][k] - Second[i, j][k], 2);
                    }
                }
            }
            return Result;
        }

        static int SimilarityScale(int[,][] ToCalc, int RowCount, int ColCount)
        {
            var Result = 0;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    for (int k = 0; k < 256; k++)
                    {
                        Result += ToCalc[i, j][k];
                    }
                }
            }
            return Result;
        }

        private void CompareOutput_Click(object sender, EventArgs e)
        {

        }

        private void SaveName_TextChanged(object sender, EventArgs e)
        {
            NameOfSavedPicture = SaveName.Text + ".jpg";
        }
        private void SavePath_TextChanged(object sender, EventArgs e)
        {
            PathOfSavedPicture = SavePath.Text;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        private void PathLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxGammaCorection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGammaCorection.Checked)
            {
                numericUpDownGamma.Enabled = true;
            }
            else
            {
                numericUpDownGamma.Enabled = false;
            }
        }

        private void numericUpDownGamma_ValueChanged(object sender, EventArgs e)
        {
            double gammaValue = Convert.ToDouble(numericUpDownGamma.Value);
            ia.GammaCorrection(gammaValue);

            UpdatePictureBoxAfter();
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            var SelectedFolder = Directory.GetFiles(PathToLoadFolder);
            string NameWithExtension;
            var PictureNameCounter = 1;

            // Debug to delete
            Debug.WriteLine(SelectedFolder.ToString());

            foreach (var Item in SelectedFolder)
            {
                AlgorithmLbph Current = new AlgorithmLbph();
                Image test = Bitmap.FromFile(Item);
                Current.ProcessedImage = (Bitmap)test;
                NameWithExtension = PictureNameCounter.ToString() + ".jpg";

                Current.Lbph(5).SaveProcessedImageToFile(NameWithExtension, PathForImages);
                PictureNameCounter += 1;
            }
        }

        private void PathOfFolder_TextChanged(object sender, EventArgs e)
        {
            PathToLoadFolder = PathOfFolder.Text;

            EnableProcessingFolder();
        }

        private void PathToSaveImages_TextChanged(object sender, EventArgs e)
        {
            PathForImages = PathToSaveImages.Text;

            EnableProcessingFolder();
        }

        private void EnableProcessingFolder()
        {
            if (PathToSaveImages.Text.Length > 0 && PathOfFolder.Text.Length > 0)
            {
                ConvertEveryPicture.Enabled = true;
                ScaleButton.Enabled = true;
            }
            if (PathToSaveImages.Text.Length == 0 || PathOfFolder.Text.Length == 0)
            {
                ConvertEveryPicture.Enabled = false;
                ScaleButton.Enabled = false;
            }
        }

        public void SavePicture(Bitmap ImageToSave, string NameToSave, string PathToSave)
        {
            // zapis z ustaleniem tylko nazwy
            if (PathOfSavedPicture.Length == 0)
            {
                ImageToSave.Save(NameToSave);
            }
            else
            {
                // pobiera nazwe i sciezke z pol do wpisania
                var ToSave = ia.ProcessedImage;
                string pathstring = System.IO.Path.Combine(PathToSave, NameToSave);

                // zapisywanie obrazka
                ToSave.Save(pathstring);
            }
        }

        private void ConvertEveryPicture_Click(object sender, EventArgs e)
        {

            var SelectedFolder = Directory.GetFiles(PathToLoadFolder);
            string NameWithExtension;
            var PictureNameCounter = 1;

            foreach (var Item in SelectedFolder)
            {
                AlgorithmLbph Current = new AlgorithmLbph();
                Image OpenedPicture = Bitmap.FromFile(Item);
                Current.ProcessedImage = (Bitmap)OpenedPicture;
                NameWithExtension = PictureNameCounter.ToString() + ".jpg";

                Current.Lbph(5).SaveProcessedImageToFile(NameWithExtension, PathForImages);
                PictureNameCounter += 1;
            }
        }

        private void PathWhereToSavePictures_Click(object sender, EventArgs e)
        {

        }

        private void splitContainerAplication_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PathToCSV_TextChanged(object sender, EventArgs e)
        {
            PathForCSV = PathToCSV.Text;
        }

        private void CompareAndSaveResults_Click(object sender, EventArgs e)
        {
            var SelectedFolder = Directory.GetFiles(PathToLoadFolder);
            int Files = SelectedFolder.Length;
            AdvancedSimilarity[] Results = new AdvancedSimilarity[Files];
            string Name;
            int Index;
            int RowCount = 3;
            int ColCount = 3;

            for (int i = 0; i < Files; i++)
            {
                Results[i] = new AdvancedSimilarity(RowCount, ColCount);
            }
            foreach (var Item in SelectedFolder)
            {
                Name = Item.Substring(PathToLoadFolder.Length + 1, Item.Length - PathToLoadFolder.Length - 5);
                Index = Int32.Parse(Name) - 1;

                Results[Index].Name = Name;
                DividePicture((Bitmap)Bitmap.FromFile(Item), Results[Index].BitmapParts);
                ArrayHistogramValues(Results[Index].BitmapParts, Results[Index].Shades, RowCount, ColCount);
            }

            for (int i = 0; i < Files; i++)
            {
                Debug.WriteLine(Results[i].Name);
            }

            int[,] CrossValidation = new int[Results.Length, Results.Length];
            int[,][] Sum = new int[RowCount, ColCount][];

            for (int i = 0; i < Results.Length; i++)
            {
                for (int j = 0; j < Results.Length; j++)
                {
                    Sum = ComparePicturesShades(Results[i].Shades, Results[j].Shades, RowCount, ColCount);
                    CrossValidation[i, j] = SimilarityScale(Sum, RowCount, ColCount);
                }
            }

            string Text;
            Text = "Index\t";
            File.AppendAllText(PathForCSV, Text, Encoding.UTF8);
            Text = null;
            for (int i = 1; i <= Results.Length; i++)
            {
                Text += i.ToString() + ",\t\t";
            }
            Text += Environment.NewLine;
            File.AppendAllText(PathForCSV, Text, Encoding.UTF8);

            for (int i = 0; i < Results.Length; i++)
            {
                Text = (i + 1).ToString() + ",\t";
                for (int j = 0; j < Results.Length; j++)
                {
                    if (CrossValidation[i,j].ToString().Length < 7)
                        Text += CrossValidation[i, j].ToString() + ",\t\t";

                    else
                        Text += CrossValidation[i, j].ToString() + ",\t";
                }

                Text += Environment.NewLine;
                File.AppendAllText(PathForCSV, Text, Encoding.UTF8);
            }
            Debug.WriteLine("Koniec");
        }


        private void pictureBoxBefore_Click(object sender, EventArgs e)
        {

        }

        private void PathToResults_Click(object sender, EventArgs e)
        {

        }

        void Scale()
        {
            var SelectedFolder = Directory.GetFiles(PathToLoadFolder);
            int NumberOfFiles = SelectedFolder.Length;
            int NameCounter = 1;

            foreach(var Item in SelectedFolder)
            {
                ImageFactory imageFactory = new ImageFactory();
                imageFactory.Load(Item);
                imageFactory.Resize(ScaleSize);
                imageFactory.Save($@"{PathForImages}\{NameCounter}.jpg");
                imageFactory.Dispose();
                NameCounter++;
            }

        }

        private void ScaleButton_Click_1(object sender, EventArgs e)
        {
            Scale();
        }

        private void FaceRecognition_Click(object sender, EventArgs e)
        {
            var Dir = Directory.GetFiles(PathToLoadFolder).ToList<string>();

            var Pictures = from Pic in Dir
                       where Pic.Substring(Pic.Length - 3, 3) == "jpg"
                       select Pic;

            var Tab = new int[Pictures.Count()];
            int RowCount = 3;
            int ColCount = 3;
            int counter = 0;
            int? min = null;
            string PersonRecognized = "Blad programu";

            int[,][] Shades = new int[RowCount,ColCount][];
            Bitmap[,] BitmapMatrix = new Bitmap[RowCount, ColCount];
            DividePicture(imageAfter, BitmapMatrix);
            ArrayHistogramValues(BitmapMatrix, Shades, RowCount, ColCount);


            Bitmap bitmap;
            AdvancedSimilarity[] Base = new AdvancedSimilarity[Pictures.Count()];

            foreach (var item in Pictures)
            {
                bitmap = (Bitmap)Image.FromFile(item);
                Base[counter] = new AdvancedSimilarity(RowCount, ColCount);
                Base[counter].Name = item.Substring(PathToLoadFolder.Length + 1, item.Length - PathToLoadFolder.Length - 5);
                DividePicture(bitmap, Base[counter].BitmapParts);
                ArrayHistogramValues(Base[counter].BitmapParts, Base[counter].Shades, RowCount, ColCount);
                var calc = ComparePicturesShades(Shades, Base[counter].Shades, RowCount, ColCount);
                Tab[counter] = SimilarityScale(calc, RowCount, ColCount);
                if (min == null)
                    min = Tab[counter];
                else if (Tab[counter] < min)
                {
                    min = Tab[counter];
                    PersonRecognized = Base[counter].Name;
                }
                counter ++;
            }

            Debug.WriteLine($"Person from image {PersonRecognized} is recognised");

        }
    }
}
