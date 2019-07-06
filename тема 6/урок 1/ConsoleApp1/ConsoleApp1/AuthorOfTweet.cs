using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
      class AuthorOfTweet : Tweet
    {
        
        bool authentic;
        string hrefName; //Cсылка на твитер аккаунт, через @

       public AuthorOfTweet(string username, bool authentic, string hrefName)
            : base (username)
        {
            this.authentic = authentic;
            this.hrefName = hrefName;

        }
    }
}
