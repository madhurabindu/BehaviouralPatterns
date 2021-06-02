using System;

namespace Library.MessageRouter
{
    /// <summary>
    /// Internal implementation of interface
    /// </summary>
    internal class ProgressImpl : IProgress
    {
        /// <summary>
        /// Interface implementation
        /// </summary>
        public PState ProgressState { get; private set; }
        /// <summary>
        /// Interface prop
        /// </summary>
        public int Step { get; private set; }
        /// <summary>
        /// Interface prop
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// interface 
        /// </summary>
        public object[] Params { get; set; }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="state"></param>
        /// <param name="msg"></param>
        /// <param name="progress"></param>
        /// <param name="list"></param>
        internal ProgressImpl(PState state, string msg, int progress, params object[] list)
        {
            ProgressState = state;
            Message = msg;
            Step = progress;
            Params = list;
        }
    }
}
