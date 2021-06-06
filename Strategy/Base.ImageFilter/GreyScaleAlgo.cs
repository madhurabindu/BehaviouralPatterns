using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Base.ImageFilter
{
    class GreyScaleAlgo : BaseAlgorithm
    {
        public override Image PerformAction(Image image)
        {
            ColorMatrix matrix = new ColorMatrix(new float[][]
                                    {
                            new float[]{.3f, .3f, .3f, 0, 0},
                            new float[]{.59f, .59f, .59f, 0, 0},
                            new float[]{.11f, .11f, .11f, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                                    });
            return base.ApplyColorMatrix(image, matrix);
        }
    }
}
