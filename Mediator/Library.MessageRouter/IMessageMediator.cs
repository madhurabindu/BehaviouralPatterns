using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.MessageRouter
{
    public interface IMessageMediator
    {
        void RegisterConsumer(IMessageConsumer consumer);

        void SendMessage(string message, MType type, params object[] list);
    }
}
