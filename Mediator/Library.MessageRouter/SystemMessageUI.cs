using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Library.MessageRouter
{
    /// <summary>
    /// UI for system message and progress display
    /// </summary>
    public partial class SystemMessageUI : UserControl
    {
        /// <summary>
        /// ctor
        /// </summary>
        public SystemMessageUI()
        {
            InitializeComponent();
            SysMsgRouter.Instance.NewMessage += OnNewMessage;
            SysMsgRouter.Instance.NewProgress += OnNewProgress;
            SysMsgRouter.Instance.NewNotification += OnNewNotifcation;
        }
        /// <summary>
        /// Max limit
        /// </summary>
        [Category("Appearance"),
        Description("Max number of messages in combobox"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always)]
        public int MaxMessageInList { get; set; } = 50;
        /// <summary>
        /// Label text
        /// </summary>
        [Category("Appearance"),
        Description("Label1 Text"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always)]
        public string Label1 { get { return labelLabel1.Text; } set { labelLabel1.Text = value; } }
        /// <summary>
        /// Label text
        /// </summary>
        [Category("Appearance"),
        Description("Label2 Text"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always)]
        public string Label2 { get { return labelLabel2.Text; } set { labelLabel2.Text = value; } }
        /// <summary>
        /// Label text
        /// </summary>
        [Category("Appearance"),
        Description("Label3 Text"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always)]
        public string Label3 { get { return labelLabel3.Text; } set { labelLabel3.Text = value; } }

        #region Private Event handlers 
        /// <summary>
        /// Update the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNewMessage(object sender, MsgArgs e)
        {
            if (this.InvokeRequired)
            {
                var A = new Action(() => OnNewMessage(sender, e));
                this.BeginInvoke(A);
                return;
            }

            if (comboMessage.Items.Count > MaxMessageInList)
            {
                comboMessage.Items.Clear();
            }
            comboMessage.Items.Insert(0, string.Format("{0}: {1}", e.Message.MessageType.ToString("F"), e.Message.Message));
            comboMessage.SelectedIndex = 0;
            progressBar.Focus();
        }
        /// <summary>
        /// Update the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNewProgress(object sender, ProgressArgs e)
        {
            if (this.InvokeRequired)
            {
                var A = new Action(() => OnNewProgress(sender, e));
                this.BeginInvoke(A);
                return;
            }

            labelProgressText.Text = e.Progress.Message;
            if (e.Progress.ProgressState == PState.Begin)
            {
                progressBar.Step = e.Progress.Step > 0 ? (int)(100 / e.Progress.Step) : 0;
                progressBar.Value = 0;
            }
            else if (e.Progress.ProgressState == PState.End)
            {
                progressBar.Value = 100;
            }
            else
            {
                progressBar.Value = progressBar.Step * e.Progress.Step;
            }
            Invalidate();
        }
        /// <summary>
        /// Update the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNewNotifcation(object sender, MsgArgs e)
        {
            if (this.InvokeRequired)
            {
                var A = new Action(() => OnNewNotifcation(sender, e));
                this.BeginInvoke(A);
                return;
            }
            bool show = (bool)e.Message.Params[0];
            btnNotification.Image = show ? global::Library.MessageRouter.Properties.Resources.bell_64 : null;
            btnNotification.Tag = e.Message;
        }
        /// <summary>
        /// TBD Currently just displays a message, a Animated UI should be displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnNotificationClicked(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                var A = new Action(() => OnBtnNotificationClicked(sender, e));
                this.BeginInvoke(A);
                return;
            }

            string message = (string)btnNotification.Tag;
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
            }
        }
        #endregion
    }
}
