namespace App.Main
{
    partial class MainApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(12, 35);
            this.txtDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocument.Multiline = true;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(715, 242);
            this.txtDocument.TabIndex = 0;
            this.txtDocument.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(733, 62);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 55);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestore.Location = new System.Drawing.Point(733, 150);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(84, 55);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 322);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(826, 37);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status Here..";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUndo,
            this.toolStripRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 35);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndo.Image")));
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(65, 32);
            this.toolStripUndo.Text = "Undo";
            this.toolStripUndo.Click += new System.EventHandler(this.toolStripUndo_Click);
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedo.Image")));
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(61, 32);
            this.toolStripRedo.Text = "Redo";
            this.toolStripRedo.Click += new System.EventHandler(this.toolStripRedo_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 359);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDocument);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainApp";
            this.Text = "Document Editor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
    }
}

