using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace ImageProcessing.Model
{
    public class AlgorithmLbph : ImageAfter
    {
        public unsafe AlgorithmLbph Lbph(int radius)
        {
            var image = ProcessedImage;
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int R = radius;
            double max = 0.0;

            byte* scan0 = (byte*)imageData.Scan0.ToPointer();
            byte* scan1 = (byte*)imageData.Scan0.ToPointer();
            int stride = imageData.Stride;
            int bytesPerPixel = 3;
            int NumRow = image.Height;
            int numCol = image.Width;
            for (int i = 0; i < NumRow; i = i + 1)
            {
                for (int j = 0; j < numCol; j = j + 1)
                {
                    if ((i > R) && (j > R) && (i < (NumRow - R)) && (j < (numCol - R)))
                    {
                        byte* row1 = scan0 + ((i) * stride);
                        List<int> vals = new List<int>();
                        int Bglowny = j * bytesPerPixel;
                        int Gglowny = Bglowny + 1;
                        int Rglowny = Bglowny + 2;
                        byte GpixelR = row1[Rglowny];
                        byte GpixelG = row1[Gglowny];
                        byte GpixelB = row1[Bglowny];
                        for (int i1 = i - R; i1 <= (i + R); i1 += R)
                        {

                            byte* row0 = scan0 + (i1 * stride);
                            for (int j1 = j - R; j1 <= (j + R); j1 += R)
                            {

                                int Rporo = (j1 * bytesPerPixel) + 2;
                                byte PpixelR = row0[Rporo];
                                if (PpixelR <= GpixelR)
                                {
                                    vals.Add(1);
                                }
                                else
                                {
                                    vals.Add(0);
                                }
                            }
                        }
                        double d = 0;

                        for (int f = 0; f < vals.Count; f++)
                        {
                            d += vals[f] * Math.Pow(2, f);
                        }
                        if (d > max)
                        { max = d; }
                        d = (d / max * 0.90) * 255;
                        //przyciemnienie zdjecia zmiana skali natężenia barwy(dla wygladu)
                        double d1 = d;
                        row1[Rglowny] = (byte)d1;
                        row1[Gglowny] = (byte)d1;
                        row1[Bglowny] = (byte)d1;

                        if (d1 > 255)
                        {
                            d1 = 255;
                            row1[Rglowny] = (byte)d1;
                            row1[Gglowny] = (byte)d1;
                            row1[Bglowny] = (byte)d1;
                            row1[Rglowny] = Convert.ToByte(row1[Rglowny]);
                            row1[Gglowny] = Convert.ToByte(row1[Gglowny]);
                            row1[Bglowny] = Convert.ToByte(row1[Bglowny]);
                        }
                        else
                        if (d1 < 0)
                        {
                            d1 = 0;
                            row1[Rglowny] = (byte)d1;
                            row1[Gglowny] = (byte)d1;
                            row1[Bglowny] = (byte)d1;
                            row1[Rglowny] = Convert.ToByte(row1[Rglowny]);
                            row1[Gglowny] = Convert.ToByte(row1[Gglowny]);
                            row1[Bglowny] = Convert.ToByte(row1[Bglowny]);
                        }
                        else
                        {
                            row1[Rglowny] = (byte)d1;
                            row1[Gglowny] = (byte)d1;
                            row1[Bglowny] = (byte)d1;
                            row1[Rglowny] = Convert.ToByte(row1[Rglowny]);
                            row1[Gglowny] = Convert.ToByte(row1[Gglowny]);
                            row1[Bglowny] = Convert.ToByte(row1[Bglowny]);
                        }
                    }

                }

            }

            image.UnlockBits(imageData);
            return this;
        }
    }
}
