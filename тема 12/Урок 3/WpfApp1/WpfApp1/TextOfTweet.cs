using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace WpfApp1
{
    class TextOfTweet : ITweet
    {
        const string consumerKey = "x6roMQs0MZ1PwjNmAELfziqq9";
        const string consumerSecret = "LztwfuCe5wFMbTh2i5MmCuBCcog2taz39Jfock7CiCJbooWWJP";
       string user = 

        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime TimeOfTweet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ITweet.TextOfTweet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowTextOfTweet()
        {
            TwitterService service = new TwitterService(consumerKey, consumerSecret);
            List<TwitterStatus> tweets;
          
            tweets = (List<TwitterStatus>)service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(tweets[i].CreatedDate);
                DateTime dateTweets = tweets[i].CreatedDate;
                var tweetsData = DateTime.Today.Subtract(dateTweets);
                var todayDate = DateTime.Now;
                var todayDataHours = DateTime.Today.Subtract(todayDate);

                Console.WriteLine(tweets[i].Text);

                Console.WriteLine();

            }
           
        }
    }
}
