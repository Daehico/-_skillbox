using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace TwitterEnity
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

            foreach( var _tweet in tweets)
            {
                using (var db = new TwitterContext())
                {

                    //добавление
                    db.Tweet.Add(new Tweets { TextOfTweet = _tweet.Text, CreatedDate = _tweet.CreatedDate });
                    db.SaveChanges();

                    //редактирование
                    var firstTweet = db.Tweet.FirstOrDefault();
                    firstTweet.TextOfTweet = "test";
                    db.SaveChanges();
                }
            }



            //var trends = service.ListLocalTrendsFor(new ListLocalTrendsForOptions() { Id = 1 }); // 1 - весь мир

            //foreach(var _trends in trends)
            //{
            //    using (var db = new TwitterContext())
            //    {
            //        db.Trend.Add(new Trends { TrendName = _trends.Name});
            //        db.SaveChanges();
            //    }
            //}


            //using (var db = new TwitterContext())
            //{
            //    var _tweets = db.Tweet.Where(t => t.Id <= 10).OrderByDescending(x => x.CreatedDate).ToList();

            //    foreach(var _textTweet in _tweets)
            //    {
            //        Console.WriteLine(_textTweet.TextOfTweet);
            //    }

            //    var _tweets2 = db.Tweet.Where(t => t.Id <= 10).OrderBy(x => x.Id).ToList();

            //    foreach( var _textTweet2 in _tweets2)
            //    {
            //        Console.WriteLine(_textTweet2.TextOfTweet);
            //    }

            //    var _trendsList = db.Trend.Select(y => new TrendsModel
            //    {
            //        Name = y.TrendName
            //    }).ToList();

            //    foreach(var _trend in _trendsList)
            //    {
            //        Console.WriteLine(_trend.Name);
            //    }

            Console.ReadKey();
        }

           
        }
    }

    public class TrendsModel
    {
        public string Name { get; set; }
    }

