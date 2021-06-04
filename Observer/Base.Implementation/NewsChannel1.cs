using Base.Interface;
using System;

namespace Base.Implementation
{
    public class NewsChannel1 : IBroadcastChannel
    {
        public ChannelType CType { get { return ChannelType.News;  }   }

        public NewsChannel1(NewsAgency agency)
        {
            agency.AddObserver(this);
        }
        public void Update(News news)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("{0, -15}: {1}", this.GetType().Name, news.ToString());
            Console.ForegroundColor = color;
        }
    }
}
