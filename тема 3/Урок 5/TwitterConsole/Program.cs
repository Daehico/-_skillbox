using System;
using System.Diagnostics;
using System.Linq;
using TweetSharp;

namespace TwitterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string consumerKey = "x6roMQs0MZ1PwjNmAELfziqq9";
            const string consumerSecret = "LztwfuCe5wFMbTh2i5MmCuBCcog2taz39Jfock7CiCJbooWWJP";
            var service = new TwitterService(consumerKey, consumerSecret);

            var requestToken = service.GetRequestToken();

            var uri = service.GetAuthorizationUri(requestToken);
            Process.Start(uri.ToString());

            var verifier = Console.ReadLine();
            var access = service.GetAccessToken(requestToken, verifier);

            service.AuthenticateWith(access.Token, access.TokenSecret);

            var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions()).ToList();

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(tweets[i].CreatedDate);
                DateTime dateTweets = tweets[i].CreatedDate;
                var tweetsData = DateTime.Today.Subtract(dateTweets);
                var todayDate = DateTime.Now;
                var todayDataHours = DateTime.Today.Subtract(todayDate);

               Console.WriteLine("Твит опубликован {0} дней назад", todayDataHours.Days - tweetsData.Days);
                Console.WriteLine("Твит опубликован {0} часов назад", todayDataHours.Hours - tweetsData.Hours);
                Console.WriteLine("Твит опубликован {0} минут назад", todayDataHours.Minutes - tweetsData.Minutes);

                Console.WriteLine(tweets[i].Text);
                Console.WriteLine();
             

                
            }

            var trends = service.ListLocalTrendsFor(new ListLocalTrendsForOptions() { Id = 1 }); // 1 - весь мир

            foreach (var trend in trends)
            {
                Console.WriteLine(trend.Name);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
