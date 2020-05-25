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
using System.Data.SqlClient;
using System.Data;

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

            while (true)
            {

                Console.WriteLine("Для того что бы сохранить твиты в базу данных введите команду - сохранить.");
                Console.WriteLine("Для того что бы ввывести сохраненные твиты введите команду - вывести");
                Console.WriteLine("Для того что бы выйти введите команду - выйти");

                var command = Console.ReadLine();

                if (command.ToLower() == "сохранить")
                {

                    foreach (TwitterStatus text in _tenTweets.ToList())
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7LNKM4H\SQLEXPRESS;Initial Catalog=TwitterDB;Integrated Security=True"))
                        {
                            connection.Open();
                            var add = new SqlCommand("insert Tweets (TextOfTweet, CreatedDate, IdOfAuthor) values(@TweetText, @CreatedDate, 1)", connection);
                            add.Parameters.Add("@TweetText", SqlDbType.NText).Value = text.Text;
                            add.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = text.CreatedDate;
                            add.ExecuteNonQuery();

                        }
                    }
                }

                if (command.ToLower() == "вывести")
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7LNKM4H\SQLEXPRESS;Initial Catalog=TwitterDB;Integrated Security=True"))
                    {
                        connection.Open();
                        var readCommand = new SqlCommand("select t.ID,t.TextOfTweet,t.CreatedDate from Tweets t", connection);
                        var read = readCommand.ExecuteReader();
                        while (read.Read())
                        {
                            Console.WriteLine(read.GetValue(0));
                            Console.WriteLine(read["TextOfTweet"]);
                            Console.WriteLine(read["CreatedDate"]);
                            Console.WriteLine();


                        }
                    }
                }

                if(command.ToLower() == "выйти")
                {
                    break;
                }


            }
        }
    }
}
   
    

