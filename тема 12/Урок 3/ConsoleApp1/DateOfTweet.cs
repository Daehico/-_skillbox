using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DateOfTweet : Tweet
    {


        public DateOfTweet(int day, int mounth, int year)
           : base(day, mounth, year)
        {
        }

        public int Day
        {
            get
            {
                return this.day;
            }

        }

        public int Mounth
        {
            get
            {
                return this.mounth;
            }

        }

        public int Year
        {
            get
            {
                return this.year;
            }

        }
    }
}
