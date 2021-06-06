namespace App.Main
{
    partial class Form1
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
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.btnRequestReturn = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuyNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuyNow.Location = new System.Drawing.Point(420, 18);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(169, 59);
            this.btnBuyNow.TabIndex = 0;
            this.btnBuyNow.Text = "Place Order";
            this.btnBuyNow.UseVisualStyleBackColor = false;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App.Main.Properties.Resources.item;
            this.pictureBox1.Location = new System.Drawing.Point(31, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelOrder.Location = new System.Drawing.Point(604, 18);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(169, 59);
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTrack.Location = new System.Drawing.Point(420, 130);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(169, 59);
            this.btnTrack.TabIndex = 3;
            this.btnTrack.Text = "Track Order";
            this.btnTrack.UseVisualStyleBackColor = false;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(0, 352);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(800, 23);
            this.statusLabel.TabIndex = 4;
            // 
            // btnRequestReturn
            // 
            this.btnRequestReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRequestReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRequestReturn.Location = new System.Drawing.Point(604, 130);
            this.btnRequestReturn.Name = "btnRequestReturn";
            this.btnRequestReturn.Size = new System.Drawing.Size(169, 59);
            this.btnRequestReturn.TabIndex = 5;
            this.btnRequestReturn.Text = "RequestReturn";
            this.btnRequestReturn.UseVisualStyleBackColor = false;
            this.btnRequestReturn.Click += new System.EventHandler(this.btnRequestReturn_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddToCart.Location = new System.Drawing.Point(276, 30);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(127, 143);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnRequestReturn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuyNow);
            this.Name = "Form1";
            this.Text = "Order Laptop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuyNow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button btnRequestReturn;
        private System.Windows.Forms.Button btnAddToCart;
    }
}

