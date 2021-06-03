using System;

namespace Library.MessageRouter
{
    /// <summary>
    /// Type of Messagee
    /// </summary>
    public enum MType { Info, Error, Warning, Critical };

    /// <summary>
    /// Message interface
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Message
        /// </summary>
        string Message { get; }
        /// <summary>
        /// Type of message
        /// </summary>
        MType MessageType { get; }
        /// <summary>
        /// aditional params
        /// </summary>
        object[] Params { get; set; }
    }

    
}
