using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.MessageRouter
{
    class CriticalMessageHandler
    {
        internal void HandleCriticalState()
        {
            Console.WriteLine("------------------> In Critical Error Handler");
            Console.WriteLine("\tCalling system event to save all Data");
            Thread.Sleep(200);
            Console.WriteLine("\tRaising Last chance Exception Handler");
            Thread.Sleep(200);
            Console.WriteLine("\tInforming user to watch out!!!");
            Thread.Sleep(200);
        }
    }
}
