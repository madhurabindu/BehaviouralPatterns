using Library.MessageRouter;
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
    public partial class MainApp : Form, IMessageConsumer
    {
        AppWindow app1, app2, app3, app4;
        public MainApp()
        {
            InitializeComponent();

            MsgMediator.Instance.RegisterConsumer(this);

            app1 = new AppWindow(MType.Info);
            app1.Text = "App Window 1";
            app2 = new AppWindow(MType.Error);
            app2.Text = "App Window 2";
            app3 = new AppWindow(MType.Warning);
            app3.Text = "App Window 3";
            app4 = new AppWindow(MType.Critical);
            app4.Text = "App Window 4";
        }

        public void Consume(IMessage message)
        {
            msgLabel.Text = string.Format("{0}\n{1} : {2}", msgLabel.Text, 
                message.MessageType, message.Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            app2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            app3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            app4.Show();

        }
    }
}
