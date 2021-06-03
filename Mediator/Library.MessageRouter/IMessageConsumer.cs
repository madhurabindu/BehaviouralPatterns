using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.MessageRouter
{
    public interface IMessageConsumer
    {
        void Consume(IMessage message);
    }
}
