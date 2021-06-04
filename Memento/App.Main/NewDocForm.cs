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
    public partial class NewDocForm : Form
    {
        public NewDocForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text))
            {
                Hide();
                MainApp app = new MainApp();
                app.SetNewDocData(textBox1.Text, textBox2.Text, textBox3.Text);
                app.ShowDialog();
                Show();
            }
        }
    }
}
