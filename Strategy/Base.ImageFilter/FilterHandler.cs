using System;
using System.Drawing;

namespace Base.ImageFilter
{

    public class FilterHandler
    {
        private ImageHandler imageHandler;
        public FilterHandler()
        {
            imageHandler = new ImageHandler();
        }

        public Image ApplyFilter(Image image, string filterName)
        {
            Image output = null;
            var algo = AlgoFactory.CreateAlgo(filterName);
            if (algo != null)
            {
                imageHandler.Algorithm = algo;
                output = imageHandler.ApplyFilter(image);
            }

            return output;
        }
    }
}
