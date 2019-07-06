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
        Tweet tweet;

        public TextOfTweet(string text, string hashtag)
            : base(text)
        {
            this.text = text;
            this.hashtag = hashtag;


        }
       

       

       public string Text { get; set; }

        public string Hashtag { get; set; }
    }

       

    }
