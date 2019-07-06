using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class StringHelper
    {
      private const int stringCut = 140;
        TextOfTweet text;
       

        public static string Cut(string text)
        {
            string cutTextOfTweet;
             try {
                cutTextOfTweet = text.Substring(0, stringCut); }

            catch (Exception e) {
                cutTextOfTweet = text;
            }
            return cutTextOfTweet;
        }


    }
}
