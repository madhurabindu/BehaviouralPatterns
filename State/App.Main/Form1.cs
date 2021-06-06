using System;
using System.Windows.Forms;

namespace App.Main
{
    public partial class Form1 : Form
    {
        public enum OrderState { None, InCart, Ordered, Shipped, OutForDelivery, Delivered, Cancelled, ReturnRequested, Returned}
        private OrderState state ;

        public Form1()
        {
            InitializeComponent();
            UpdateButtonState();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            state = OrderState.InCart;
            UpdateButtonState();
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            state = OrderState.Ordered;
            UpdateButtonState();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            state = OrderState.Cancelled;
            UpdateButtonState();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            // Mimic order moving from one state to other here....
        }

       
        private void btnRequestReturn_Click(object sender, EventArgs e)
        {
            state = OrderState.ReturnRequested;
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            switch (state)
            {
                case OrderState.InCart:
                    {
                        btnAddToCart.Enabled = false;
                        btnBuyNow.Enabled = true;
                        btnCancelOrder.Enabled = false;
                        btnRequestReturn.Enabled = false;
                        btnTrack.Enabled = false;
                        break;
                    }
                case OrderState.Ordered:
                    {
                        btnAddToCart.Enabled = false;
                        btnBuyNow.Enabled = false;
                        btnCancelOrder.Enabled = true;
                        btnRequestReturn.Enabled = false;
                        btnTrack.Enabled = true;
                        break;
                    }
                case OrderState.OutForDelivery:
                    {
                        btnAddToCart.Enabled = false;
                        btnBuyNow.Enabled = false;
                        btnCancelOrder.Enabled = false;
                        btnRequestReturn.Enabled = false;
                        btnTrack.Enabled = true;
                        break;
                    }
                case OrderState.Delivered:
                    {
                        btnAddToCart.Enabled = true;
                        btnBuyNow.Enabled = false;
                        btnCancelOrder.Enabled = false;
                        btnRequestReturn.Enabled = true;
                        btnTrack.Enabled = false;
                        break;
                    }
                case OrderState.ReturnRequested:
                    {
                        btnAddToCart.Enabled = false;
                        btnBuyNow.Enabled = false;
                        btnCancelOrder.Enabled = false;
                        btnRequestReturn.Enabled = false;
                        btnTrack.Enabled = true;
                        break;
                    }
                case OrderState.Returned:
                    {
                        btnAddToCart.Enabled = true;
                        btnBuyNow.Enabled = false;
                        btnCancelOrder.Enabled = false;
                        btnRequestReturn.Enabled = false;
                        btnTrack.Enabled = true;
                        break;
                    }
                case OrderState.None:
                default:
                    {
                        btnAddToCart.Enabled = true;
                        btnBuyNow.Enabled = false;
                        btnCancelOrder.Enabled = false;
                        btnRequestReturn.Enabled = false;
                        btnTrack.Enabled = false;
                        break;
                    }
            }

        }

        
    }
}
