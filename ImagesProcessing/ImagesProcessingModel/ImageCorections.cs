using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging;

namespace ImagesProcessingModel
{
    public class ImageCorections
    {
        public void Contrast(ProcessedImage image, int value)
        {
            var i = image.Image;
            using (MemoryStream inStream = new MemoryStream())
            {
                i.Save(inStream, image.ImageFormat);
                inStream.Position = 0;
                using (var imageFactory = new ImageFactory(preserveExifData: false))
                {
                    imageFactory.Load(inStream)
                                .Contrast(value)
                                .Save(inStream);
                }
                image.Image = new Bitmap(Image.FromStream(inStream));
            }
        }
        public void Gamma(ProcessedImage image, float value)
        {
            var i = image.Image;
            using (MemoryStream inStream = new MemoryStream())
            {
                i.Save(inStream, image.ImageFormat);
                inStream.Position = 0;

                using (var imageFactory = new ImageFactory(preserveExifData: false))
                {
                    imageFactory.Load(inStream)
                                .Gamma(value)
                                .Save(inStream);
                }
                image.Image = new Bitmap(Image.FromStream(inStream));
            }
        }
        public void Saturation(ProcessedImage image, int value)
        {
            var i = image.Image;
            using (MemoryStream inStream = new MemoryStream())
            {
                i.Save(inStream, image.ImageFormat);
                inStream.Position = 0;

                using (var imageFactory = new ImageFactory(preserveExifData: false))
                {
                    imageFactory.Load(inStream)
                                .Saturation(value)
                                .Save(inStream);
                }
                image.Image = new Bitmap(Image.FromStream(inStream));
            }
        }
        public void Resize(ProcessedImage image, Size newSize)
        {
            var i = image.Image;
            var r = new ResizeLayer(newSize, ResizeMode.Crop);
            using (MemoryStream inStream = new MemoryStream())
            {
                i.Save(inStream, image.ImageFormat);
                inStream.Position = 0;
                using (var imageFactory = new ImageFactory(preserveExifData: false))
                {
                    imageFactory.Load(inStream)
                                .Resize(r)
                                .Save(inStream);
                }
                image.Image = new Bitmap(Image.FromStream(inStream));
            }
        }
    }
}
