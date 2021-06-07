using Base.ImageFilter;
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
        private FilterHandler handler;

        public MainApp()
        {
            InitializeComponent();
            handler = new FilterHandler();

        }

        private void toolStripNegative_Click(object sender, EventArgs e)
        {
            string algoName = (string)toolStripNegative.Tag;
            var outImage = handler.ApplyFilter(pBoxIn.Image, algoName);
            pBoxOut.Image = new Bitmap(outImage);

        }

        private void toolStripTrans_Click(object sender, EventArgs e)
        {
            string algoName = (string)toolStripTrans.Tag;
            var outImage = handler.ApplyFilter(pBoxIn.Image, algoName);
            pBoxOut.Image = new Bitmap(outImage);

        }

        private void toolStripSepia_Click(object sender, EventArgs e)
        {
            string algoName = (string)toolStripSepia.Tag;
            var outImage = handler.ApplyFilter(pBoxIn.Image, algoName);
            pBoxOut.Image = new Bitmap(outImage);

        }

        private void toolStripGreyScale_Click(object sender, EventArgs e)
        {
            string algoName = (string)toolStripGreyScale.Tag;
            var outImage = handler.ApplyFilter(pBoxIn.Image, algoName);
            pBoxOut.Image = new Bitmap(outImage);
        }
    }
}
