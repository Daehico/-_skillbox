using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Station<T>
    {

        static public string Send(string value, string value1)
        {
            var a = value1 + ": Отправить " + value;
            return a;

        }

    static public string Accept(string value, string value1)
        {
            var a = value1 + ": Принять " + value;
            return a;

        }

    }
}
