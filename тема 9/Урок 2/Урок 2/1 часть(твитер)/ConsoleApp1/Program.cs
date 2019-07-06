using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        private static object service;

        static void Main(string[] args)
        {
            var author1 = new AuthorOfTweet("Дмитрий Дудин", false, "@Daehico");
            var author2 = new AuthorOfTweet("Евгений Ройзман",true, "@roizmanfond");

            var date1 = new DateOfTweet(14,07,2018);
            var date2 = new DateOfTweet(21, 05, 2017);

            var text1 = new TextOfTweet("Привет, Твиттер! ", "#мойпервыйТвит");
            var text2 = new TextOfTweet("В 55 лет для меня каждый марафон испытание. Мне надо обязательно выбежать из 4х часов. Пусть даже за 3 часа 59 мин. Зачем? Вот я буду старым, пристанут ко мне внуки: «Дедушка, а за сколько ты марафон пробежал?», а я: «Да, за 3 часа»", " ");
            var text3 = new TextOfTweet("Задача организации, в особенности же новая модель организационной деятельности влечет за собой процесс внедрения и модернизации форм развития. Не следует, однако забывать, что рамки и место обучения кадров требуют от нас анализа модели развития. Не следует, однако забывать, что дальнейшее развитие различных форм деятельности требуют определения и уточнения позиций, занимаемых участниками в отношении поставленных задач. Равным образом постоянный количественный рост и сфера нашей активности влечет за собой процесс внедрения и модернизации существенных финансовых и административных условий. Равным образом рамки и место обучения кадров обеспечивает широкому кругу (специалистов) участие в формировании направлений прогрессивного развития. С другой стороны рамки и место обучения кадров позволяет оценить значение модели развития.", "");

            

            var view = new ViewATweet();
            view.View(text1, date1, author1);
            view.View(text2, date2, author2);
            var result1 = text1.text;


            var textString = StringHelper.Cut(result1);
            Console.WriteLine(textString);
            
            var authenticator = Authenticator.Authenticators();
            var textOfTweets = TextOfTweet.TextOfTweets();
            string trends = TextOfTweet.TwitterTrends().ToString();
            int countTrends = TextOfTweet.CountTrends();
            Console.WriteLine(countTrends);

            Console.ReadKey();

        }



            
        }
   
    }

