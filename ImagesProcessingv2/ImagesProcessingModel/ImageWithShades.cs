using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImagesProcessingModel
{
    public class ImageWithShades
    {
        public string Name { get; set; }
        public Bitmap Bitmapa { get; set; }
        public int[] GrayScale = new int[256];

        public void SetGrayScale(int[] Tab)
        {
            for (int i = 0; i < 256; i++)
            {
                GrayScale[i] = Tab[i];
            }
        }
    }
}
