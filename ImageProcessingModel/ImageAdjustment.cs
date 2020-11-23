using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace ImageProcessing.Model
{
    public class ImageAdjustment : ImageAfter
    {
        public ImageAfter ConvertToGreyscale()
        {
            var image = ProcessedImage;

            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr scan0 = imageData.Scan0; // First pixel adress

            // Image colors (BGR not RGB)
            byte[] imageDataBytes = new byte[Math.Abs(imageData.Stride) * imageData.Height];
            var imageDataBytesLenght = imageDataBytes.Length;
            var imageDataBytesWidth = Math.Abs(imageData.Stride);

            Marshal.Copy(scan0, imageDataBytes, 0, imageDataBytesLenght);

            int width = 3;
            int i = 3;
            while (i < imageDataBytesLenght)
            {
                byte pixelB = imageDataBytes[i - 3];
                byte pixelR = imageDataBytes[i - 1];
                byte pixelG = imageDataBytes[i - 2];

                byte intensityWeight = Convert.ToByte(0.299 * pixelR + 0.587 * pixelG + 0.114 * pixelB);

                imageDataBytes[i - 3] = imageDataBytes[i - 1] = imageDataBytes[i - 2] = intensityWeight;

                if (width >= imageDataBytesWidth)
                {
                    i += imageDataBytesWidth - width;
                    width = 0;
                    continue;
                }
                i += bytesPerPixel;
                width += bytesPerPixel;
            }

            Marshal.Copy(imageDataBytes, 0, scan0, imageDataBytesLenght);
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
        public ImageAfter AddLinearGradient(Point start, Point end, Size relativeSize)
        {
            var image = ProcessedImage;

            double imageAspectRatio = Convert.ToDouble(image.Width) / Convert.ToDouble(image.Height);
            int relativeImageHeight = Convert.ToInt32(relativeSize.Width / imageAspectRatio);

            int deltaY = (relativeSize.Height - relativeImageHeight) / 2;

            double scaleForX = Convert.ToDouble(image.Width) / Convert.ToDouble(relativeSize.Width);
            double scaleForY = Convert.ToDouble(image.Height) / Convert.ToDouble(relativeImageHeight);

            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr scan0 = imageData.Scan0; // First pixel adress

            // Image colors (BGR not RGB)
            byte[] imageDataBytes = new byte[Math.Abs(imageData.Stride) * imageData.Height];
            var imageDataBytesLenght = imageDataBytes.Length;
            var imageDataBytesWidth = Math.Abs(imageData.Stride);

            Marshal.Copy(scan0, imageDataBytes, 0, imageDataBytesLenght);

            int width = 3;
            int height = 0;

            double x1 = start.X * scaleForX; 
            double y1 = (start.Y - deltaY) * scaleForY;
            double x2 = end.X * scaleForX; 
            double y2 = (end.Y - deltaY) * scaleForY; 

            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;

            double gradientWidthLimit = Math.Abs((height - b) / a) * bytesPerPixel;
            double gradientHeightLimit = (end.Y - deltaY) * scaleForY;

            if (start.X == end.X)
            {
            }
            //if (start.Y == end.Y)
            //{
            //}

            int i = 3;
            while (i < imageDataBytesLenght)
            {
                byte pixelB = imageDataBytes[i - 3];
                byte pixelR = imageDataBytes[i - 1];
                byte pixelG = imageDataBytes[i - 2];

                imageDataBytes[i - 3] = 255;
                imageDataBytes[i - 1] = 0;
                imageDataBytes[i - 2] = 0;

                if (width >= gradientWidthLimit)
                {
                    i += imageDataBytesWidth - width;
                    width = 0;
                    gradientWidthLimit = Math.Abs((height - b) / a) * bytesPerPixel;

                    height++;
                    if (height >= gradientHeightLimit)
                    {
                        break;
                    }

                    continue;
                }
                i += bytesPerPixel;
                width += bytesPerPixel;
            }

            Marshal.Copy(imageDataBytes, 0, scan0, imageDataBytesLenght);
            image.UnlockBits(imageData);

            return this;
        }
    }
}
