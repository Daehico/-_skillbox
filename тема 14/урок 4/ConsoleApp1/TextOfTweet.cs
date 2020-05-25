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
        public string Text { get; private set; }
        public TextOfTweet(string text) : base(text)
        {
            Text = text;
        }

       



        //public static explicit operator TextOfTweet(string v)
        //{

        //    return new TextOfTweet {text = v};
        //}
    }

   

}
