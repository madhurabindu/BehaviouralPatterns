using Base.Interface;
using System;

namespace Base.Implementation
{
    public class MusicNowChannel : IBroadcastChannel
    {
        public ChannelType CType { get { return ChannelType.Music; } }

        private NewsAgency subject;
        public MusicNowChannel(NewsAgency agency)
        {
            subject = agency;
            subject.AddObserver(this);
        }

        public void Update(News news)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0, -15}: {1}", this.GetType().Name, news.ToString());
            Console.ForegroundColor = color;

        }

        public void BeginMusicConcert()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" <----------------- Beginning of Music concert --------------> ");
            Console.ForegroundColor = color;

            // Handle the start of broadcasting of a musci concert...
            // ...
            // ....
            // lastly remove news updates during concert
            subject.RemoveObserver(this);
        }

        public void EndMusicConcert()
        {
            // Handle the end of broadcasting of a musci concert...
            // ...
            // ...
            // lastly add back news updates after concert
            subject.AddObserver(this);
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" <----------------- End of Music concert --------------> ");
            Console.ForegroundColor = color;

        }
    }
}
