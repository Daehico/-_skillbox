using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TweetSharp;

namespace ConsoleApp1
{
    public class TextOfTweet : Tweet
    {
       
        string hashtag;
        Tweet tweet;

        public TextOfTweet(string text, string hashtag)
            : base(text)
        {
            this.text = text;
            this.hashtag = hashtag;

        }
        
        public string Text { get; set; }

        public string Hashtag { get; set; }

        Authenticator authenticator;
        TwitterService service = Authenticator.service;

        public static object TextOfTweets()
        {
            List<TwitterStatus> tweets;
            TwitterService service = Authenticator.service;
            tweets = (List<TwitterStatus>)service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());

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
            return tweets[15].Text;
        }

        public static TwitterTrends trends;

        public static List<String> twitterTrends;

        public static string TwitterTrends()
        {
            trends = Authenticator.service.ListLocalTrendsFor(new ListLocalTrendsForOptions() { Id = 1 }); // 1 - весь мир
            twitterTrends = new List<string>();
            foreach (var trend in trends)
            {
                var a = trend.Name.ToString();
                twitterTrends.Add(a);
                twitterTrends.Sort();

                var b = a.IndexOf('\u0023');


                if (b == 0)
                {
                    var builder = new StringBuilder();
                    builder.Append(a);


                    Console.WriteLine(builder.ToString());
                }

            }
            return twitterTrends.ToString();
        }

        public static int CountTrends()
        {
            var countTrends = twitterTrends.Count();
            return countTrends;
        }
    }
}





