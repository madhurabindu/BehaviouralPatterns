using System;

namespace Base.StateMachine
{
    public class InCartState : IOrderState
    {
        public void Cancel(Order context)
        {
            context.State = new CancelledState();
        }

        public void MoveNext(Order context)
        {
            context.State = new OrderedState();
        }

        public void PerformStateAction(Order context)
        {
            Console.WriteLine("Item has been Added to cart....");
        }

    }

    public class CancelledState : IOrderState
    {
        public void Cancel(Order context)
        {
            context.State = new CancelledState();
        }

        public void MoveNext(Order context)
        {
            Console.WriteLine("Order is in Cancelled state, no more transition possible");
        }

        public void PerformStateAction(Order context)
        {
            Console.WriteLine("Item has been Cancelled....");
        }

    }

    public class OrderedState : IOrderState
    {
        public void Cancel(Order context)
        {
            context.State = new CancelledState();
        }

        public void MoveNext(Order context)
        {
            context.State = new ShippedState();
        }

        public void PerformStateAction(Order context)
        {
            Console.WriteLine("Item has been Ordered....");
        }

    }

    public class ShippedState : IOrderState
    {
        public void Cancel(Order context)
        {
            context.State = new CancelledState();
        }

        public void MoveNext(Order context)
        {
            context.State = new OutForDeliveryState();
        }

        public void PerformStateAction(Order context)
        {
            Console.WriteLine("Item has been Shipped....");
        }

    }

    public class OutForDeliveryState : IOrderState
    {
        public void Cancel(Order context)
        {
            Console.WriteLine("Can not cancel the Order, the order is out for delivery");
        }

        public void MoveNext(Order context)
        {
            context.State = new Delivered();
        }

        public void PerformStateAction(Order context)
        {
            Console.WriteLine("Item has been Out for delivery....");
        }

    }

    public class Delivered : IOrderState
    {
        public void Cancel(Order context)
        {
            Console.WriteLine("Can not cancel the Order, the order is Delivered");
        }

        public void MoveNext(Order context)
        {
            Console.WriteLine("Order is in Delivered state, no more transition possible");
        }

        public void PerformStateAction(Order context)
        {
            Console.WriteLine("Item has been Delivered....");
        }

    }
}
