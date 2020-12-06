using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ImageProcessing.Model
{
    public class ImageAfter
    {
        protected int bytesPerPixel = 3;
        public Bitmap ProcessedImage { get; set; }

        public ImageAfter SaveProcessedImageToFile(string fileName)
        {
            ProcessedImage.Save(fileName);
            return this;
        }

        public void SaveProcessedImageToFile(string fileName, string path)
        {
            // pobiera nazwe i sciezke z pol do wpisania
            string pathstring = System.IO.Path.Combine(path, fileName);

            // zapisywanie obrazka
            ProcessedImage.Save(pathstring);
        }


    }
}
