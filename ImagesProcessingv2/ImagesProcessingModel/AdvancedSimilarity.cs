using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

namespace ImagesProcessingModel
{
    public class AdvancedSimilarity
    {
        public string Name { get; set; }
        public Bitmap[,] BitmapParts { get; set; }

        public int[,][] Shades { get; set; }

        public AdvancedSimilarity(int RowCount, int Colcount)
        {
            BitmapParts = new Bitmap[RowCount, Colcount];
            Shades = new int[RowCount, Colcount][];
        }


        void SetShades(int Row, int Col, int[] Grayscale)
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    for (int k = 0; k < 256; k++)
                    {
                        Shades[i, j][k] = Grayscale[k];
                    }
                }
            }
        }
    }
}
