using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.StateMachine
{
    public interface IOrderState
    {
        void PerformStateAction(Order context);

        void MoveNext(Order context);
        void Cancel(Order context);
    }
    public enum OrderState { None, InCart, Ordered, Shipped, OutForDelivery, Delivered, Cancelled, ReturnRequested, Returned }


    public class Order
    {

        public IOrderState State { get; set; }
        public int Id { get; private set; }

        public Order(int id)
        {
            Id = id;
        }
        public void MoveNext()
        {
            State.MoveNext(this);
            State.PerformStateAction(this);
        }
        public void Cancel()
        {
            State.Cancel(this);
        }
       
    }
}
