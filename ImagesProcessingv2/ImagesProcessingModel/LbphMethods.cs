using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcessingModel
{
    public class LbphMethods
    {
        public static void DividePicture(Bitmap BitmapToDivide, Bitmap[,] BitmapsMatrix)
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

        public static void HistogramValues(Bitmap ToCalculate, out int[] Shades)
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

        public static void ArrayHistogramValues(Bitmap[,] BitmapMatrix, int[,][] AllShades, int RowCount, int ColCount)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    HistogramValues(BitmapMatrix[i, j], out AllShades[i, j]);
                }
            }
        }

        public static int[,][] ComparePicturesShades(int[,][] First, int[,][] Second, int RowCount, int ColCount)
        {
            var Result = new int[RowCount, ColCount][];
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    Result[i, j] = new int[256];
                    for (int k = 0; k < 256; k++)
                    {
                        Result[i, j][k] = (int)Math.Abs(First[i, j][k] - Second[i, j][k]);
                        //Result[i, j][k] = (int)Math.Pow(First[i, j][k] - Second[i, j][k], 2);
                    }
                }
            }
            return Result;
        }

        public static int SimilarityScale(int[,][] ToCalc, int RowCount, int ColCount)
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

        public void CrossValidation(ProcessedImages Images, string PathOfTxt)
        {
            //var SelectedFolder = Directory.GetFiles(PathToLoadFolder);
            var SelectedFolder = Images;
            int Files = SelectedFolder.Images.Count;
            AdvancedSimilarity[] Results = new AdvancedSimilarity[Files];
            int Index = 0;
            int RowCount = 3;
            int ColCount = 3;

            for (int i = 0; i < Files; i++)
            {
                Results[i] = new AdvancedSimilarity(RowCount, ColCount);
            }

            foreach (var Item in SelectedFolder.Images)
            {
                Results[Index].Name = Item.ImageName;
                DividePicture(Item.Image, Results[Index].BitmapParts);
                ArrayHistogramValues(Results[Index].BitmapParts, Results[Index].Shades, RowCount, ColCount);
                Index++;
            }

            for (int i = 0; i < Files; i++)
            {
                Debug.WriteLine(Results[i].Name);
            }

            float[,] CrossValidation = new float[Results.Length, Results.Length];
            int[,][] Sum = new int[RowCount, ColCount][];

            for (int i = 0; i < Results.Length; i++)
            {
                for (int j = 0; j < Results.Length; j++)
                {
                    Sum = ComparePicturesShades(Results[i].Shades, Results[j].Shades, RowCount, ColCount);
                    CrossValidation[i, j] = ((float)(SimilarityScale(Sum, RowCount, ColCount)) / 77760) * 100;        // hard coded 77760 (workes only with pic 320x243)
                    /*CrossValidation[i, j] = SimilarityScale(Sum, RowCount, ColCount);*/
                }
            }

            string Text;
            Text = "Index\t";
            PathOfTxt += "\\CrossValidation.txt";
            File.AppendAllText(PathOfTxt, Text, Encoding.UTF8);
            Text = null;
            for (int i = 1; i <= Results.Length; i++)
            {
                Text += i.ToString() + ",\t\t";
            }
            Text += Environment.NewLine;
            File.AppendAllText(PathOfTxt, Text, Encoding.UTF8);

            for (int i = 0; i < Results.Length; i++)
            {
                Text = (i + 1).ToString() + ",\t";
                for (int j = 0; j < Results.Length; j++)
                {
                    if (CrossValidation[i, j].ToString().Length < 7)
                        Text += CrossValidation[i, j].ToString() + ",\t\t";

                    else
                        Text += CrossValidation[i, j].ToString() + ",\t";
                }

                Text += Environment.NewLine;
                File.AppendAllText(PathOfTxt, Text, Encoding.UTF8);
            }

            Text = "\n\nLegenda:\n";
            for (int i = 0; i < Results.Length; i++)
            {
                Text += $"{Results[i].Name} = {i + 1}\n";
            }
            File.AppendAllText(PathOfTxt, Text, Encoding.UTF8);

            Debug.WriteLine("Koniec");
        }
    }
}
