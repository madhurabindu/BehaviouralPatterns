using System;

namespace Library.MessageRouter
{
    /// <summary>
    /// Type of progress
    /// </summary>
    public enum PState { Begin, Proceed, End };

    /// <summary>
    /// Progress interface
    /// </summary>
    public interface IProgress
    {
        /// <summary>
        /// Step
        /// </summary>
        int Step { get; }
        /// <summary>
        /// State of progress
        /// </summary>
        PState ProgressState { get; }
        /// <summary>
        /// Message
        /// </summary>
        string Message { get; }
        /// <summary>
        /// Additional params
        /// </summary>
        object[] Params { get; set; }
    }
}
