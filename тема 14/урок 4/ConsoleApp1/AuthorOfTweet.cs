using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace ConsoleApp1
{
    public class AuthorOfTweet : Tweet
    {
        bool authentic;
        string hrefName; //Cсылка на твитер аккаунт, через @

        public AuthorOfTweet(string username, bool authentic, string hrefName)
             : base(username.ToString())
        {
            this.authentic = authentic;
            this.hrefName = hrefName;

        }
        public string Name
        {
            get
            {
                return this.username.ToString();
            }

        }

        public bool Authentic
        {
            get
            {
                return this.authentic;
            }

        }

        public string HrefName
        {
            get
            {
                return this.hrefName;
            }

        }
    }
}
