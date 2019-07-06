using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Tweet
    {
        public string username;
        public string text;
        public int day;
        public int mounth;
        public int year;

        public Tweet(string username, string text, int day, int mouth, int year)
        {
            this.username = username;
            this.text = text;
            this.day = day;
            this.mounth = mounth;
            this.year = year;

        }

        protected Tweet(string text)
        {
            this.text = text;
        }
        protected Tweet(int day, int mouth, int year)
        {
            this.day = day;
            this.mounth = mounth;
            this.year = year;
        }
    }
    }
