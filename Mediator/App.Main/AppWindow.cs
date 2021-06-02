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
    public partial class AppWindow : Form, IMessageConsumer
    {
        MType mType;
        public AppWindow(MType type)
        {
            InitializeComponent();
            MsgMediator.Instance.RegisterConsumer(this);
            mType = type;
        }

        public void Consume(IMessage message)
        {
            msgLabel.Text = string.Format("{0}\n{1} : {2}", msgLabel.Text,
                message.MessageType, message.Message);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MsgMediator.Instance.SendMessage(textBox1.Text, mType);
        }
    }
}
