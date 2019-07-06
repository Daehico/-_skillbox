using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    interface ITweet
    {
        string Username { get; set; } 
        string Login { get; set; }
        DateTime TimeOfTweet { get; set; }
        string TextOfTweet { get; set; }
        void ShowTextOfTweet();
    }
}
