using Base.Lib.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Main
{
    public partial class MainApp : Form
    {
        bool firstUndoClick = true;
        Caretaker_UndoRedo undoRedoCaretaker = new Caretaker_UndoRedo();
        SingleStateCaretaker singleCaretaker = new SingleStateCaretaker();
        Document doc = null;
        public MainApp()
        {
            InitializeComponent();
        }

        public void SetNewDocData(string id, string author, string title)
        {
            doc = new Document() { Author = author, ID = id, Title = title };
            UpdateStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doc.Content = txtDocument.Text;
            Memento m = doc.CreateBackup();
            singleCaretaker.Save(m);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Memento m = singleCaretaker.Restore();
            doc.Content = m.Content;
            txtDocument.Text = doc.Content;

            UpdateStatus();
        }

        private void toolStripUndo_Click(object sender, EventArgs e)
        {
            if (firstUndoClick)
            {
                btnSave_Click(null, null);
            }
            Memento m = undoRedoCaretaker.Pop();
            if (m != null)
            {
                doc.Content = m.Content;
                txtDocument.Text = doc.Content;
                UpdateStatus();
            }
            firstUndoClick = false;
        }

        private void toolStripRedo_Click(object sender, EventArgs e)
        {
            firstUndoClick = true;
            btnRestore_Click(null, null);
        }

        private void UpdateStatus()
        {
            lblStatus.Text = doc.ToString();
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            doc.Content = txtDocument.Text;
            Memento m = doc.CreateBackup();
            undoRedoCaretaker.Push(m);

        }
    }
}
