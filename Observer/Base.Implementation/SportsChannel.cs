using Base.Interface;
using System;

namespace Base.Implementation
{
    public class SportsChannel : IBroadcastChannel
    {
        public ChannelType CType { get { return ChannelType.Sports; } }

        public SportsChannel(NewsAgency agency)
        {
            agency.AddObserver(this);
        }

        public void Update(News news)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0, -15}: {1}", this.GetType().Name, news.ToString());
            Console.ForegroundColor = color;
        }
    }
}
