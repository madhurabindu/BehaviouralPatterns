using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lib.Document
{
    public class Caretaker_UndoRedo
    {
        Stack<Memento> stack = new Stack<Memento>();
        public void Push(Memento m)
        {
            stack.Push(m);
        }

        public Memento Pop()
        {
            return stack.Count > 0 ? (Memento)stack.Pop() : null;
        }
    }

    public class SingleStateCaretaker
    {
        private Memento lastKnownState;
        public void Save(Memento m)
        {
            lastKnownState = m;
        }

        public Memento Restore()
        {
            return lastKnownState;
        }
    }
}
