using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private static object service;

        static void Main(string[] args)
        {
            Tweet[] _tweets = new Tweet[10];
           
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
            var trends = service.ListLocalTrendsFor(new ListLocalTrendsForOptions { Id = 1 });

            Tweet tweet = new Tweet();

            tweet.username = tweets.Select(x => x.Author);
            tweet.text = tweets.Select(y => y.Text);
            tweet.day = tweets.Select(z => z.CreatedDate);

            var trendsName = trends.Where(i => i.Name.StartsWith("#")).Select(d => d.Name);
           

            var _tenTweets = tweets.Take(10);

           

            foreach (TwitterStatus text in _tenTweets.ToList())
            {
                Console.WriteLine(text.Text);
            }


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(tweets[i].Text);

            //    string test1 = tweets[i].Author.ToString();
            //    string test2 = tweets[i].Text;
            //    DateTime test3 = tweets[i].CreatedDate;

            //    tweet = new Tweet(test1, test2, test3);

            //    _tweets[i] = tweet;

            //    Console.WriteLine();
            //}

            //XmlSerializer formatter = new XmlSerializer(typeof(Tweet[]));
            //using (FileStream fs = new FileStream("tweets.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, _tweets);

            //    Console.WriteLine("Объект сериализован");
            //}



            Console.ReadKey();

        }



            
        }
   
    }

