using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Enumarable
{

    /// <summary>

    /// The 'Iterator' abstract class

    /// </summary>

    public interface  Iterator

    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }

    public interface  Aggregator
    {
        Iterator CreateIterator();
    }
}
