using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.ImageFilter
{
    class AlgoFactory
    {
        public static IAlgorithm CreateAlgo(string name)
        {
            IAlgorithm algo = null;
            switch (name)
            {
                case Constants.GreyScale:
                    {
                        algo = new GreyScaleAlgo();
                        break;
                    }
                case Constants.Transparent:
                    {
                        algo = new TransparentAlgo();
                        break;
                    }
                case Constants.Sepia:
                    {
                        algo = new SepiaAlgo();
                        break;
                    }
                case Constants.Negative:
                    {
                        algo = new NegativeAlgo();
                        break;
                    }
                default:
                    break;
            }

            return algo;
        }
    }
}
