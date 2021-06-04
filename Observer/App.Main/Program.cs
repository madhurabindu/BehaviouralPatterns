using Base.Implementation;
using Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAgency agency = new NewsAgency();

            MusicNowChannel ch1 = new MusicNowChannel(agency);
            NewsChannel1 ch2 = new NewsChannel1(agency);
            NewsChannel2 ch3 = new NewsChannel2(agency);

            SportsChannel ch4 = new SportsChannel(agency);

            agency.Report(new News()
            {
                Message = "COVID Vaccine created",
                NewsType = News.NType.Health,
                Reporter = "Reporter1"
            });
            Console.WriteLine("\n-------------------------------------------------------------------\n");
            agency.Report(new News()
            {
                Message = "Bahamas now open for travellers",
                NewsType = News.NType.Travel,
                Reporter = "Reporter1"
            });
            Console.WriteLine("\n-------------------------------------------------------------------\n");

            agency.Report(new News()
            {
                Message = "New Season of IPL starting in August",
                NewsType = News.NType.Sports,
                Reporter = "Reporter1"
            });
            Console.WriteLine();

            ch1.BeginMusicConcert();
            Console.WriteLine();

            agency.Report(new News()
            {
                Message = "A new movie is releasing shortly",
                NewsType = News.NType.Entertainment,
                Reporter = "Reporter1"
            });
            Console.WriteLine("\n-------------------------------------------------------------------\n");
            agency.Report(new News()
            {
                Message = "All Nations sign the Paris Environment treaty",
                NewsType = News.NType.Politics,
                Reporter = "Reporter1"
            });
            Console.WriteLine("\n-------------------------------------------------------------------\n");
            agency.Report(new News()
            {
                Message = "The new iPhone hits the market this December",
                NewsType = News.NType.Tech,
                Reporter = "Reporter1"
            });

            Console.WriteLine();
            ch1.EndMusicConcert();
            Console.WriteLine();
            agency.Report(new News()
            {
                Message = "The Music Concert was a great Success!!",
                NewsType = News.NType.Entertainment,
                Reporter = "Reporter1"
            });
            Console.WriteLine("\n-------------------------------------------------------------------\n");


        }
    }
}
