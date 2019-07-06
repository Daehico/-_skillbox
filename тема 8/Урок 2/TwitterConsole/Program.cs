using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TweetSharp;

namespace TwitterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string consumerKey = "x6roMQs0MZ1PwjNmAELfziqq9";
            //const string consumerSecret = "LztwfuCe5wFMbTh2i5MmCuBCcog2taz39Jfock7CiCJbooWWJP";
            //var service = new TwitterService(consumerKey, consumerSecret);

            //var requestToken = service.GetRequestToken();

            //var uri = service.GetAuthorizationUri(requestToken);
            //Process.Start(uri.ToString());

            //var verifier = Console.ReadLine();
            //var access = service.GetAccessToken(requestToken, verifier);

            //service.AuthenticateWith(access.Token, access.TokenSecret);

            //var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions()).ToList();

            const string consumerKey = "x6roMQs0MZ1PwjNmAELfziqq9";
            const string consumerSecret = "LztwfuCe5wFMbTh2i5MmCuBCcog2taz39Jfock7CiCJbooWWJP";
            var service = new TwitterService(consumerKey, consumerSecret);

            var requestToken = service.GetRequestToken();

            var uri = service.GetAuthorizationUri(requestToken);
            Process.Start(uri.ToString());

            var verifier = Console.ReadLine();
            var access = service.GetAccessToken(requestToken, verifier);

            try
            {
                service.AuthenticateWith(access.Token, access.TokenSecret);
            }
           catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw new TwitterException("Ошибка");
            }

          System.Collections.Generic.List<TwitterStatus> tweets;
            try
            {
            tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions()).ToList();
                
            }
        catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw new TwitterException("Ошибка");
            }
            finally
            {
                tweets = null;
            }
            if (tweets == null)
            {
                Console.WriteLine("Ошибка. Нажмите Enter, что бы закрыть приложение");
            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine(tweets[i].CreatedDate);
                    DateTime dateTweets = tweets[i].CreatedDate;
                    var tweetsData = DateTime.Today.Subtract(dateTweets);
                    var todayDate = DateTime.Now;
                    var todayDataHours = DateTime.Today.Subtract(todayDate);
                    //var text = "#iiii";
                    var b = "\u0023([\\ww-]*)*";

                    Console.WriteLine("Твит опубликован {0} дней назад", todayDataHours.Days - tweetsData.Days);
                    Console.WriteLine("Твит опубликован {0} часов назад", todayDataHours.Hours - tweetsData.Hours);
                    Console.WriteLine("Твит опубликован {0} минут назад", todayDataHours.Minutes - tweetsData.Minutes);

                    var result = Regex.Match(tweets[i].Text, b, RegexOptions.IgnoreCase);
                    Console.WriteLine(tweets[i].Text);
                    Console.WriteLine(result);
                    Console.WriteLine();



                }
            }

            TwitterTrends trends;

            try
            {
                trends = service.ListLocalTrendsFor(new ListLocalTrendsForOptions() { Id = 1 }); // 1 - весь мир
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw new TwitterException("Ошибка");
            }
            finally
            {
                trends = null;
            }

            if (trends == null)
            {
                Console.WriteLine("Ошибка. Нажмите Enter, что бы закрыть приложение");
            }
            else { 
            foreach (var trend in trends)
            {
                var a = trend.Name.ToString();
                var b = a.IndexOf('\u0023');

                if (b == 0)
                {
                    var builder = new StringBuilder();
                    builder.Append(a);


                    Console.WriteLine(builder.ToString());
                }


               
            }

            }
            var twitterUser = new TwitterUser();
            var userAvatar = twitterUser.ProfileImageUrl;
            Console.WriteLine(userAvatar);
            Console.ReadKey();
        }
    }
}
