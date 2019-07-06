using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш логин или введите Логины что бы вывести список логинов");
            string login = Console.ReadLine();

            Dictionary<string, string> users = new Dictionary<string, string>();

            users.Add("Sinab", "Дмитрий");
            users.Add("Daehico", "Владимир");

            string username;
            string logins;

            if (login == "Логины")
            {
                foreach (var value in users.Values)
                {
                    Console.WriteLine(value);
                }
            }
            else
            {
                if (!users.TryGetValue(login, out logins))
                {
                    Console.WriteLine("Ваш логин не найдет. Введите ваше имя");
                    username = Console.ReadLine();
                    users.Add(login, username);
                }
                else
                {
                    username = users[logins];
                    Console.WriteLine("Здравствуйте, " + username);
                }

            }


            Console.ReadKey();
        }

        
    }

    internal class List<T1, T2>
    {
    }
}
