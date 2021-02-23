using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ImagesProcessingModel
{
    public class DetectTarget
    {
        private readonly CascadeClassifier _cascadeClassifier;

        public DetectTarget(string fileName)
        {
            _cascadeClassifier = new CascadeClassifier(fileName);
        }

        // Detect for e.g. face
        private Rectangle[] FindTargets(Bitmap image)
        {
            var grayImage = new Image<Bgr, byte>(image);
            var rectangles = _cascadeClassifier.DetectMultiScale(grayImage, 1.4, 0);
            return rectangles;
        }
        public Bitmap Crop(Bitmap image)
        {
            var ft = FindTargets(image);
            var selectOneTarget = ft.Length != 0 ? ft.OrderByDescending(element => element.Width).First() : new Rectangle(0, 0, 1, 1);
            var target = new Bitmap(selectOneTarget.Width, selectOneTarget.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(image, new Rectangle(0, 0, target.Width, target.Height), selectOneTarget, GraphicsUnit.Pixel);
            }
            return target;
        }
    }
}
