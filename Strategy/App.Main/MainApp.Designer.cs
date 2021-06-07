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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pBoxOut = new System.Windows.Forms.PictureBox();
            this.pBoxIn = new System.Windows.Forms.PictureBox();
            this.toolStripGreyScale = new System.Windows.Forms.ToolStripButton();
            this.toolStripNegative = new System.Windows.Forms.ToolStripButton();
            this.toolStripTrans = new System.Windows.Forms.ToolStripButton();
            this.toolStripSepia = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIn)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTrans,
            this.toolStripGreyScale,
            this.toolStripSepia,
            this.toolStripNegative});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pBoxOut
            // 
            this.pBoxOut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pBoxOut.Location = new System.Drawing.Point(449, 38);
            this.pBoxOut.Name = "pBoxOut";
            this.pBoxOut.Size = new System.Drawing.Size(365, 337);
            this.pBoxOut.TabIndex = 1;
            this.pBoxOut.TabStop = false;
            // 
            // pBoxIn
            // 
            this.pBoxIn.Image = global::App.Main.Properties.Resources.unnamed;
            this.pBoxIn.Location = new System.Drawing.Point(21, 38);
            this.pBoxIn.Name = "pBoxIn";
            this.pBoxIn.Size = new System.Drawing.Size(365, 337);
            this.pBoxIn.TabIndex = 0;
            this.pBoxIn.TabStop = false;
            // 
            // toolStripGreyScale
            // 
            this.toolStripGreyScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripGreyScale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGreyScale.Image")));
            this.toolStripGreyScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGreyScale.Name = "toolStripGreyScale";
            this.toolStripGreyScale.Size = new System.Drawing.Size(107, 32);
            this.toolStripGreyScale.Tag = "G";
            this.toolStripGreyScale.Text = "Grey Scale";
            this.toolStripGreyScale.Click += new System.EventHandler(this.toolStripGreyScale_Click);
            // 
            // toolStripNegative
            // 
            this.toolStripNegative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNegative.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNegative.Image")));
            this.toolStripNegative.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNegative.Name = "toolStripNegative";
            this.toolStripNegative.Size = new System.Drawing.Size(95, 32);
            this.toolStripNegative.Tag = "N";
            this.toolStripNegative.Text = "Negative";
            this.toolStripNegative.Click += new System.EventHandler(this.toolStripNegative_Click);
            // 
            // toolStripTrans
            // 
            this.toolStripTrans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTrans.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTrans.Image")));
            this.toolStripTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTrans.Name = "toolStripTrans";
            this.toolStripTrans.Size = new System.Drawing.Size(129, 32);
            this.toolStripTrans.Tag = "T";
            this.toolStripTrans.Text = "Transperancy";
            this.toolStripTrans.Click += new System.EventHandler(this.toolStripTrans_Click);
            // 
            // toolStripSepia
            // 
            this.toolStripSepia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSepia.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSepia.Image")));
            this.toolStripSepia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSepia.Name = "toolStripSepia";
            this.toolStripSepia.Size = new System.Drawing.Size(64, 32);
            this.toolStripSepia.Tag = "S";
            this.toolStripSepia.Text = "Sepia";
            this.toolStripSepia.Click += new System.EventHandler(this.toolStripSepia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pBoxOut);
            this.Controls.Add(this.pBoxIn);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Image Filters";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxIn;
        private System.Windows.Forms.PictureBox pBoxOut;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNegative;
        private System.Windows.Forms.ToolStripButton toolStripTrans;
        private System.Windows.Forms.ToolStripButton toolStripSepia;
        private System.Windows.Forms.ToolStripButton toolStripGreyScale;
    }
}

