using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace ConsoleApp1
{
    [Serializable]
    public class TextOfTweet : Tweet
    {
        public TextOfTweet(string text) : base(text)
        {
            this.text = text;
        }

        public static explicit operator TextOfTweet(string v)
        {
            TextOfTweet text = (TextOfTweet)v;
            return text;
        }
    }



}
