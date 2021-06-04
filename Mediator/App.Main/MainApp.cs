using Library.MessageRouter;
using System;
using System.Windows.Forms;

namespace App.Main
{
    public partial class MainApp : Form
    {
        AppWindow app1, app2, app3, app4;

       

        public MainApp()
        {
            InitializeComponent();

            app1 = new AppWindow(MType.Info);
            app1.Text = "App Window Info Message Handler";
            MsgMediator.Instance.RegisterConsumer(app1, MType.Info);

            app2 = new AppWindow(MType.Error);
            app2.Text = "App Window Error Message Handler";
            MsgMediator.Instance.RegisterConsumer(app2, MType.Error);

            app3 = new AppWindow(MType.Warning);
            app3.Text = "App Window Warning Message Handler";
            MsgMediator.Instance.RegisterConsumer(app3, MType.Warning);

            app4 = new AppWindow(MType.Critical);
            app4.Text = "App Window Critical Message Handler";
            MsgMediator.Instance.RegisterConsumer(app4, MType.Critical);

            listBox1.SelectedIndex = 0;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            app1.Show();
            app2.Show();
            app3.Show();
            app4.Show();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MType type = (MType)Enum.Parse(typeof(MType), (string)listBox1.SelectedItem);
            MsgMediator.Instance.SendMessage(textBox1.Text, type);

            msgLabel.Text = string.Format("{0}\n{1} : {2}", msgLabel.Text,
                type, textBox1.Text);

        }

    }
}
