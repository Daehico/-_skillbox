using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class StringHelper
    {
      private const int stringCut = 140;
        TextOfTweet textOfTweet;
               
       public string Cut()
        {
            string text = textOfTweet.ToString();
            var cutTextOfTweet = text.Substring(stringCut, text.Length);
            return cutTextOfTweet;
        }


    }
}
