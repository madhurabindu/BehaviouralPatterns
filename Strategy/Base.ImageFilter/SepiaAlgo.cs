using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Base.ImageFilter
{
    class SepiaAlgo : BaseAlgorithm
    {
        public override Image PerformAction(Image image)
        {
            ColorMatrix matrix = new ColorMatrix(new float[][]
                            {
                        new float[]{.393f, .349f, .272f, 0, 0},
                        new float[]{.769f, .686f, .534f, 0, 0},
                        new float[]{.189f, .168f, .131f, 0, 0},
                        new float[]{0, 0, 0, 1, 0},
                        new float[]{0, 0, 0, 0, 1}
                            });
            
            return base.ApplyColorMatrix(image, matrix);
        }
    }
}
