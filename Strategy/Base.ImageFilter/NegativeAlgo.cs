using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Base.ImageFilter
{
    class NegativeAlgo : BaseAlgorithm
    {
        public override Image PerformAction(Image image)
        {
            ColorMatrix matrix = new ColorMatrix(new float[][]
                   {
                            new float[]{-1, 0, 0, 0, 0},
                            new float[]{0, -1, 0, 0, 0},
                            new float[]{0, 0, -1, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{1, 1, 1, 1, 1}
                   });
            return base.ApplyColorMatrix(image, matrix);
        }
    }
}
