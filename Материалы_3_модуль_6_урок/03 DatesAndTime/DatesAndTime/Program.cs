using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var yesterday = DateTime.Today.AddDays(-1);
            Console.WriteLine("Вчера было {0}", yesterday);

            var tomorrow = DateTime.Today.Add(TimeSpan.FromDays(1));
            Console.WriteLine("Завтра будет {0}", tomorrow.DayOfWeek);

            Console.Write("Введите дату рождения: ");
            var birthDateAsString = Console.ReadLine();
            var birthDate = DateTime.Parse(birthDateAsString);

            var age = DateTime.Today.Subtract(birthDate);

            Console.WriteLine("Ваш возраст {0} дней", age.Days);

            Console.ReadKey();
        }
    }
}
