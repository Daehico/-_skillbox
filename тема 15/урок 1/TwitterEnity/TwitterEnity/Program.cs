using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterEnity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TwitterContext())
            {
                db.Tweet.Add(new Tweets { TextOfTweet = "text", CreatedDate = DateTime.Now });
                db.SaveChanges();
            }
        }
    }
}
