using System;
using System.Collections.Generic;

namespace Library.MessageRouter
{
    /// <summary>
    /// Public event router class
    /// </summary>
    public class MsgMediator : IMessageMediator
    {
        private Dictionary<MType, IMessageConsumer> consumerList;

        private IMessageConsumer criticalConsumer;
        /// <summary>
        /// Static instance creation
        /// </summary>
        static MsgMediator()
        {
            Instance = new MsgMediator();
        }
        /// <summary>
        /// Singleton access
        /// </summary>
        public static MsgMediator Instance { get; private set; }
        /// <summary>
        /// Private ctor
        /// </summary>
        private MsgMediator()
        {
            consumerList = new Dictionary<MType, IMessageConsumer>();
        }

        public void RegisterConsumer(IMessageConsumer consumer, MType type)
        {
            consumerList[type] = consumer;
        }

        /// <summary>
        /// Send to event subscriber
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void SendMessage(string message, MType type, params object[] list)
        {
            MessageImpl m = new MessageImpl(type, message);
            consumerList[type]?.Consume(m);
        }

       
     
    }

   
}
