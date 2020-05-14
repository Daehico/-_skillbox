using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace ConsoleApp1
{
    public class Tweet
    {
        public string username;
        public string text;
        public DateTime day;
        public int dayInt;
        public int mounth;
        public int year;

        public Tweet(string username, string text, DateTime day)
        {
            this.username = username;
            this.text = text;
            this.day = day;
          

        }
       public Tweet()
        {

        }

        protected Tweet(string text)
        {
            this.text = text;
        }
        protected Tweet(int day, int mouth, int year)
        {
            this.dayInt = day;
            this.mounth = mounth;
            this.year = year;
        }
    }
}