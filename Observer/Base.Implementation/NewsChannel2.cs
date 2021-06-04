using Base.Interface;
using System;

namespace Base.Implementation
{
    public class NewsChannel2 : IBroadcastChannel
    {
        public ChannelType CType { get { return ChannelType.News; } }

        public NewsChannel2(NewsAgency agency)
        {
            agency.AddObserver(this);
        }

        public void Update(News news)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0, -15}: {1}", this.GetType().Name, news.ToString());
            Console.ForegroundColor = color;
        }
    }
}
