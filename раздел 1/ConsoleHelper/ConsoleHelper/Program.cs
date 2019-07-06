using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            const string timeComand = "Сколько времени";
            const string searchComand = "Найди в интернете";

            string comand;

            do
            {
                comand = Console.ReadLine();
                if (comand == timeComand)
                {

                    Console.WriteLine(DateTime.Now.ToShortTimeString());
                }
                else if (comand.StartsWith(searchComand))
                {
                    var query = comand.Substring(searchComand.Length);
                    var url = "https://yandex.ru/search/?lr=41&clid=2241984&text=" + query;
                    Process.Start(url);
                }
            }

            while (comand != "Выйти");        }
    }
}
