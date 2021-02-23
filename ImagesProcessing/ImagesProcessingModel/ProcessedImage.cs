using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ImagesProcessingModel
{
    public class ProcessedImage
    {
        public Bitmap Image { get; set; }

        internal BitmapData LockBits(Rectangle rectangle, object readWrite, object format24bppRgb)
        {
            throw new NotImplementedException();
        }

        public string ImageName { get; set; }
        public ImageFormat ImageFormat { get; private set; }

        public ProcessedImage(Bitmap image, string imageName)
        {
            Image = image;
            ImageName = imageName;
            ImageFormat = image.RawFormat;
        }
        public void Save(string path) => Image.Save($"{path}/{ImageName}");

    }
}
