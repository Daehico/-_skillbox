using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TextOfTweet : Tweet
    {
        string hashtag;

        public TextOfTweet (string text, string hashtag)
            : base(text)
        {

            this.hashtag = hashtag;


        }

        public string Text
        {
            get
            {
                return this.text;
            }

        }

        public string Hashtag
        {
            get
            {
                return this.hashtag;
            }

        }


    }
}
