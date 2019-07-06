using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var author1 = new AuthorOfTweet("Дмитрий Дудин", false, "@Daehico");
            var author2 = new AuthorOfTweet("Евгений Ройзман",true, "@roizmanfond");

            var date1 = new DateOfTweet(14,07,2018);
            var date2 = new DateOfTweet(21, 05, 2017);

            var text1 = new TextOfTweet("Привет, Твиттер! ", "#мойпервыйТвит");
            var text2 = new TextOfTweet("В 55 лет для меня каждый марафон испытание. Мне надо обязательно выбежать из 4х часов. Пусть даже за 3 часа 59 мин. Зачем? Вот я буду старым, пристанут ко мне внуки: «Дедушка, а за сколько ты марафон пробежал?», а я: «Да, за 3 часа»", " ");

            

            var view = new ViewATweet();
            view.View(text1, date1, author1);
            view.View(text2, date2, author2);

           

        }
    }
}
