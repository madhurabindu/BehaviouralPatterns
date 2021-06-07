using Base.StateMachine;
using System;
using System.Threading;
using System.Windows.Forms;

namespace App.Main
{
    public partial class Form1 : Form
    {
        public enum OrderState { None, InCart, Ordered, Shipped, OutForDelivery, Delivered, Cancelled, ReturnRequested, Returned}

        Order order;
        public Form1()
        {
            InitializeComponent();
            UpdateButtonState();
            order = new Order(1431);
            order.State = null;
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            order.State = new InCartState();
            UpdateButtonState();
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            order.MoveNext();
            UpdateButtonState();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            order.Cancel();
            UpdateButtonState();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            // Mimic order moving from one state to other here....
            bool cont = true;
            do
            {
                Thread.Sleep(500);
                order.MoveNext();
                cont = Console.ReadLine().CompareTo("q") != 0;
            }
            while (cont);
        }

       
        private void btnRequestReturn_Click(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
  /*          switch (state)
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
  */

        }

        
    }
}
