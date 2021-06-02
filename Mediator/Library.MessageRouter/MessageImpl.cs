using System;

namespace Library.MessageRouter
{
    /// <summary>
    /// The implementation class for internal use
    /// </summary>
    internal class MessageImpl : IMessage
    {
        /// <summary>
        /// Interface implementation
        /// </summary>
        public MType MessageType { get ; private set ; }
        /// <summary>
        /// Inteface prop
        /// </summary>
        public string Message { get ; private set; }
        /// <summary>
        /// Interface prop
        /// </summary>
        public object[] Params   { get ; set; }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="list"></param>
        internal MessageImpl(MType type, string message, params object[] list)
        {
            MessageType = type;
            Message = message;
            Params = list;
        }
    }
}
