namespace Library.MessageRouter
{
    partial class SystemMessageUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.labelProgressText = new System.Windows.Forms.ToolStripLabel();
            this.comboMessage = new System.Windows.Forms.ToolStripComboBox();
            this.btnNotification = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.labelLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.labelLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 48);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelProgressText,
            this.progressBar,
            this.toolStripSeparator1,
            this.comboMessage,
            this.btnNotification,
            this.toolStripSeparator2,
            this.labelLabel1,
            this.toolStripSeparator3,
            this.labelLabel2,
            this.toolStripSeparator4,
            this.labelLabel3});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1647, 32);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // labelProgressText
            // 
            this.labelProgressText.AutoSize = false;
            this.labelProgressText.Name = "labelProgressText";
            this.labelProgressText.Size = new System.Drawing.Size(300, 29);
            this.labelProgressText.Text = "progress status";
            // 
            // comboMessage
            // 
            this.comboMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMessage.Name = "comboMessage";
            this.comboMessage.Size = new System.Drawing.Size(500, 32);
            // 
            // btnNotification
            // 
            this.btnNotification.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNotification.AutoSize = false;
            this.btnNotification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNotification.Image = global::Library.MessageRouter.Properties.Resources.bell_64;
            this.btnNotification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNotification.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btnNotification.Size = new System.Drawing.Size(32, 32);
            this.btnNotification.ToolTipText = "Notification Button";
            this.btnNotification.Click += new System.EventHandler(this.OnBtnNotificationClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // labelLabel1
            // 
            this.labelLabel1.AutoSize = false;
            this.labelLabel1.Name = "labelLabel1";
            this.labelLabel1.Size = new System.Drawing.Size(130, 29);
            this.labelLabel1.Text = "Session Part: None";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // labelLabel2
            // 
            this.labelLabel2.AutoSize = false;
            this.labelLabel2.Name = "labelLabel2";
            this.labelLabel2.Size = new System.Drawing.Size(130, 29);
            this.labelLabel2.Text = "Acq Unit: None";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // labelLabel3
            // 
            this.labelLabel3.AutoSize = false;
            this.labelLabel3.Name = "labelLabel3";
            this.labelLabel3.Size = new System.Drawing.Size(130, 29);
            this.labelLabel3.Text = "Review Unit: None";
            // 
            // SystemMessageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.toolStrip);
            this.Name = "SystemMessageUI";
            this.Size = new System.Drawing.Size(1647, 32);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox comboMessage;
        private System.Windows.Forms.ToolStripButton btnNotification;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel labelLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel labelLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel labelLabel3;
        private System.Windows.Forms.ToolStripLabel labelProgressText;
    }
}
