using System;
using System.Drawing;

namespace Base.ImageFilter
{
    public class ImageHandler
    {
        IAlgorithm algorithm;

        public IAlgorithm Algorithm { get; set; }

        public Image ApplyFilter(Image image)
        {
            return algorithm.PerformAction(image);
        }
    }
}
