using System;
using System.Drawing;

namespace Base.ImageFilter
{
    public interface IAlgorithm
    {
        Image PerformAction(Image image);
    }
}
