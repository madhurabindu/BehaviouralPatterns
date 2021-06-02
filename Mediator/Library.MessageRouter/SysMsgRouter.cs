using System;

namespace Library.MessageRouter
{
    /// <summary>
    /// Public event router class
    /// </summary>
    public class SysMsgRouter
    {
        /// <summary>
        /// Event for new message
        /// </summary>
        public event EventHandler<MsgArgs> NewMessage;

        /// <summary>
        /// Event for new progress
        /// </summary>
        public event EventHandler<ProgressArgs> NewProgress;
        /// <summary>
        /// Event for new notification
        /// </summary>
        public event EventHandler<MsgArgs> NewNotification;
        /// <summary>
        /// Static instance creation
        /// </summary>
        static SysMsgRouter()
        {
            Instance = new SysMsgRouter();
        }
        /// <summary>
        /// Singleton access
        /// </summary>
        public static SysMsgRouter Instance { get; private set; }
        /// <summary>
        /// Private ctor
        /// </summary>
        private SysMsgRouter()
        {

        }
        /// <summary>
        /// Send to event subscriber
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void SendInfoMsg(string message, params object[] list)
        {
            MessageImpl m = new MessageImpl(MType.Info, message);
            NewMessage?.Invoke(this, new MsgArgs(m, list));
        }

        /// <summary>
        /// Send to event subscriber
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void SendWarningMsg(string message, params object[] list)
        {
            MessageImpl m = new MessageImpl(MType.Warning, message);
            NewMessage?.Invoke(this, new MsgArgs(m, list));
        }

        /// <summary>
        /// Send to event subscriber
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void SendErroMsgr(string message, params object[] list)
        {
            MessageImpl m = new MessageImpl(MType.Error, message);
            NewMessage?.Invoke(this, new MsgArgs(m, list));
        }
        /// <summary>
        /// Send to event subscriber
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        public void SendCriticalMsg(string message, params object[] list)
        {
            MessageImpl m = new MessageImpl(MType.Critical, message);
            NewMessage?.Invoke(this, new MsgArgs(m, list));
        }
        /// <summary>
        /// Send progress event to subscriber
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="numberOfSteps"></param>
        /// <param name="list"></param>
        public void BeginProgress(string msg, int numberOfSteps, params object[] list)
        {
            ProgressImpl p = new ProgressImpl(PState.Begin, msg, numberOfSteps);
            NewProgress?.Invoke(this, new ProgressArgs(p, list));
        }

        /// <summary>
        /// Send progress event to subscriber
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="numberOfSteps"></param>
        /// <param name="list"></param>
        public void UpdateProgress(string msg, int step, params object[] list)
        {
            ProgressImpl p = new ProgressImpl(PState.Proceed, msg, step);
            NewProgress?.Invoke(this, new ProgressArgs(p, list));
        }

        /// <summary>
        /// Send progress event to subscriber
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="numberOfSteps"></param>
        /// <param name="list"></param>
        public void EndProgress(string msg, params object[] list)
        {
            ProgressImpl p = new ProgressImpl(PState.End, msg, 100);
            NewProgress?.Invoke(this, new ProgressArgs(p, list));
        }
        /// <summary>
        /// Notify the notification event
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            MessageImpl m = new MessageImpl(MType.Critical, message);
            NewNotification?.Invoke(this, new MsgArgs(m));
        }
    }

    /// <summary>
    /// Wrap the message data in args
    /// </summary>
    public class MsgArgs : EventArgs
    {
        public IMessage Message { get; private set; }

        public MsgArgs(IMessage message, params object[] list)
        {
            Message = message;
            Message.Params = list;
        }
    }
    /// <summary>
    /// Wrap the progress data in args
    /// </summary>
    public class ProgressArgs : EventArgs
    {
        public IProgress Progress { get; private set; }

        public ProgressArgs(IProgress progress, params object[] list)
        {
            Progress = progress;
            Progress.Params = list;
        }
    }
}
