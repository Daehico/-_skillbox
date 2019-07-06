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
            TextOfTweet tweet;
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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tweets[i].Text);
                tweet = (TextOfTweet)tweets[i].Text;
                XmlSerializer formatter = new XmlSerializer(typeof(TextOfTweet));
                using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, tweet);

                    Console.WriteLine("Объект сериализован");
                }
                Console.WriteLine();
            }
            


            Console.ReadKey();

        }



            
        }
   
    }

