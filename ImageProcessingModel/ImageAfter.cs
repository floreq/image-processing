using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ImageProcessing.Model
{
    public class ImageAfter
    {
        public Bitmap ProcessedImage { get; set; }
        public ImageAfter ConvertToGreyscale()
        {
            var image = ProcessedImage;
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] imageBytes = new byte[Math.Abs(imageData.Stride) * image.Height];
            var imageBytesLenght = imageBytes.Length;
            IntPtr scan0 = imageData.Scan0;

            Marshal.Copy(scan0, imageBytes, 0, imageBytesLenght);

            for (int i = 3; i < imageBytesLenght; i += 3)
            {
                byte pixelB = imageBytes[i - 3];
                byte pixelR = imageBytes[i - 1];
                byte pixelG = imageBytes[i - 2];

                byte intensityWeight = Convert.ToByte(0.299 * pixelR + 0.587 * pixelG + 0.114 * pixelB);

                imageBytes[i - 3] = imageBytes[i - 1] = imageBytes[i - 2] = intensityWeight;
            }

            Marshal.Copy(imageBytes, 0, scan0, imageBytesLenght);
            image.UnlockBits(imageData);

            return this;
        }
        public ImageAfter AdjustContrast(float contrast)
        {
            if (contrast > 100) contrast = 100;
            else if (contrast < -100) contrast = -100;
            var factor = (259 * (contrast + 255)) / (255 * (259 - contrast));

            var image = ProcessedImage;
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] imageBytes = new byte[Math.Abs(imageData.Stride) * image.Height];
            var imageBytesLenght = imageBytes.Length;
            IntPtr scan0 = imageData.Scan0;

            Marshal.Copy(scan0, imageBytes, 0, imageBytesLenght);

            for (int i = 3; i < imageBytesLenght; i += 3)
            {
                byte pixelB = imageBytes[i - 3];
                byte pixelR = imageBytes[i - 1];
                byte pixelG = imageBytes[i - 2];

                var newContrastPixelB = factor * (pixelB - 128) + 128;
                var newContrastPixelR = factor * (pixelR - 128) + 128;
                var newContrastPixelG = factor * (pixelG - 128) + 128;

                if (newContrastPixelB > 255) imageBytes[i - 3] = 255;
                else if (newContrastPixelB < 0) imageBytes[i - 3] = 0;
                else imageBytes[i - 3] = Convert.ToByte(newContrastPixelB);

                if (newContrastPixelR > 255) imageBytes[i - 1] = 255;
                else if (newContrastPixelR < 0) imageBytes[i - 1] = 0;
                else imageBytes[i - 1] = Convert.ToByte(newContrastPixelR);

                if (newContrastPixelG > 255) imageBytes[i - 2] = 255;
                else if (newContrastPixelG < 0) imageBytes[i - 2] = 0;
                else imageBytes[i - 2] = Convert.ToByte(newContrastPixelG);
            }

            Marshal.Copy(imageBytes, 0, scan0, imageBytesLenght);
            image.UnlockBits(imageData);

            return this;
        }

        public ImageAfter AddLinearGradient(Point start, Point end)
        {
            var image = ProcessedImage;
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] imageBytes = new byte[Math.Abs(imageData.Stride) * image.Height];
            var imageBytesLenght = imageBytes.Length;
            var imageBytesWidth = Math.Abs(imageData.Stride);
            IntPtr scan0 = imageData.Scan0;

            Marshal.Copy(scan0, imageBytes, 0, imageBytesLenght);

            Debug.WriteLine("Start: {0}, End: {1}", start, end);

            int width = 0;
            int height = 0;

            //if (start.X == end.X)
            //{
            //    gradientLimit = start.X;
            //}
            //if (start.Y == end.Y)
            //{
            //}

            double x1 = 3440;
            double y1 = 0;
            double x2 = 0;
            double y2 = 2752;

            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;
            double gradientLimit = Math.Abs((height - b) / a) * 3;

            for (int i = 3; i < imageBytesLenght; i += 3, width += 3)
            {
                byte pixelB = imageBytes[i - 3];
                byte pixelR = imageBytes[i - 1];
                byte pixelG = imageBytes[i - 2];

                imageBytes[i - 3] = imageBytes[i - 1] = imageBytes[i - 2] = 0;

                if (width >= gradientLimit)
                {
                    i += imageBytesWidth - width;
                    width = 0;
                    height++;
                    gradientLimit = Math.Abs((height - b) / a) * 3;
                    continue;
                }
            }

            Marshal.Copy(imageBytes, 0, scan0, imageBytesLenght);
            image.UnlockBits(imageData);

            return this;
        }
        public ImageAfter SaveProcessedImageToFile(string fileName)
        {
            ProcessedImage.Save(fileName);
            return this;
        }
    }
}
