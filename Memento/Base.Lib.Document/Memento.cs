using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lib.Document
{
    public class Memento
    {
        public string ID { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public DateTime LastEdited { get; private set; }
        public string Content { get; private set; }

        public Memento(string id, string title, string author, DateTime lastEdited, string content)
        {
            ID = id;
            Title = title;
            Author = author;
            LastEdited = lastEdited;
            Content = content;
        }
    }

}
