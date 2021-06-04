using Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Implementation
{
    public class NewsAgency
    {
        IList<IBroadcastChannel> channels;

        public NewsAgency()
        {
            channels = new List<IBroadcastChannel>();
        }

        public void Report(News news)
        {
            foreach (var channel in channels)
            {
                channel.Update(news);
            }
        }

        public void AddObserver(IBroadcastChannel channel)
        {
            channels.Add(channel);
        }

        public void RemoveObserver(IBroadcastChannel channel)
        {
            if (channels.Contains(channel))
            {
                channels.Remove(channel);
            }
        }
    }
}
