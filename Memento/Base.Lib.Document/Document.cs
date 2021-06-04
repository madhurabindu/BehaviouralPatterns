using System;
using System.Collections;

namespace Base.Lib.Document
{
    public class Document
    {
        private string _id;
        private string _title;
        private string _author;
        private DateTime _lastEdited;
        private string _content;

        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                SetLastEdited();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                SetLastEdited();
            }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                SetLastEdited();
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public Document()
        {
            SetLastEdited();
        }

        public Memento CreateBackup()
        {
            return new Memento(_id, _title, _author, _lastEdited, _content);
        }

        public void RestoreFromBackup(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _id = memento.ID;
            _lastEdited = memento.LastEdited;
            _content = memento.Content;
        }

        public override string ToString()
        {
            return string.Format(
                "ID: {0, -6} Edited: {1, -10} -- '{2}' BY [{3}].", ID, _lastEdited, Title.ToUpper(), Author);
        }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }
    }
   
}
