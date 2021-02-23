using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesProcessingModel
{
    public class ProcessedImages
    {
        public List<ProcessedImage> Images { get; private set; } = new List<ProcessedImage>();
        public void Add(ProcessedImage image) => Images.Add(image);
        public void Save(string path)
        {
            foreach (var image in Images) image.Save(path);
        }
    }
}
