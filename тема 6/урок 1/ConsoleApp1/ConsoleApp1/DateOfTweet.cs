using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DateOfTweet : Tweet 
    {
       

        public DateOfTweet(int day, int mounth, int year)
            : base (day, mounth, year)
        {
        }

    }
}
