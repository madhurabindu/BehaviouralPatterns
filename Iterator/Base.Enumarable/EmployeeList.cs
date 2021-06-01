using System;
using System.Collections;

namespace Base.Enumarable
{
    public class EmployeeIterator : Iterator

    {
        private EmployeeList _aggregate;
        private int _current = 0;

        // Constructor

        public EmployeeIterator(EmployeeList aggregate)
        {
            this._aggregate = aggregate;
        }

        // Gets first iteration item

        public object First()
        {
            return _aggregate[0];
        }

        // Gets next iteration item

        public object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        // Gets current iteration item

        public object CurrentItem()
        {
            return _aggregate[_current];
        }

        // Gets whether iterations are complete

        public bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

    }

    /// <summary>

    /// The 'ConcreteAggregate' class

    /// </summary>

    public class EmployeeList : Aggregator

    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new EmployeeIterator(this);
        }

        // Gets item count

        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
