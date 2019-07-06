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
            #region Day of Week
            string[] dayOfWeek = new string[7];
            dayOfWeek[0] = "Понедельник";
            dayOfWeek[1] = "Вторник";
            dayOfWeek[2] = "Среда";
            dayOfWeek[3] = "Четверг";
            dayOfWeek[4] = "Пятница";
            dayOfWeek[5] = "Суббота";
            dayOfWeek[6] = "Воскресенье";

            foreach (var dayOfWeeks in dayOfWeek)
            {
                Console.WriteLine(dayOfWeeks);
                
            }
            Console.WriteLine(" ");

            Array.Reverse(dayOfWeek);
            foreach (var dayOfWeeksReverse in dayOfWeek)
            {
                Console.WriteLine(dayOfWeeksReverse);
            }




            #endregion

            #region chess
            Console.WriteLine(" ");
            int[,] chess = new int[8, 8];
            chess[0, 0] = 1;
            chess[0, 1] = 0;
            chess[0, 2] = 1;
            chess[0, 3] = 0;
            chess[0, 4] = 1;
            chess[0, 5] = 0;
            chess[0, 6] = 1;
            chess[0, 7] = 0;

            chess[1, 0] = 0;
            chess[1, 1] = 1;
            chess[1, 2] = 0;
            chess[1, 3] = 1;
            chess[1, 4] = 0;
            chess[1, 5] = 1;
            chess[1, 6] = 0;
            chess[1, 7] = 1;

            chess[2, 0] = 1;
            chess[2, 1] = 0;
            chess[2, 2] = 1;
            chess[2, 3] = 0;
            chess[2, 4] = 1;
            chess[2, 5] = 0;
            chess[2, 6] = 1;
            chess[2, 7] = 0;

            chess[3, 0] = 0;
            chess[3, 1] = 1;
            chess[3, 2] = 0;
            chess[3, 3] = 1;
            chess[3, 4] = 0;
            chess[3, 5] = 1;
            chess[3, 6] = 0;
            chess[3, 7] = 1;

            chess[4, 0] = 1;
            chess[4, 1] = 0;
            chess[4, 2] = 1;
            chess[4, 3] = 0;
            chess[4, 4] = 1;
            chess[4, 5] = 0;
            chess[4, 6] = 1;
            chess[4, 7] = 0;

            chess[5, 0] = 0;
            chess[5, 1] = 1;
            chess[5, 2] = 0;
            chess[5, 3] = 1;
            chess[5, 4] = 0;
            chess[5, 5] = 1;
            chess[5, 6] = 0;
            chess[5, 7] = 1;

            chess[6, 0] = 1;
            chess[6, 1] = 0;
            chess[6, 2] = 1;
            chess[6, 3] = 0;
            chess[6, 4] = 1;
            chess[6, 5] = 0;
            chess[6, 6] = 1;
            chess[6, 7] = 0;

            chess[7, 0] = 0;
            chess[7, 1] = 1;
            chess[7, 2] = 0;
            chess[7, 3] = 1;
            chess[7, 4] = 0;
            chess[7, 5] = 1;
            chess[7, 6] = 0;
            chess[7, 7] = 1;

            int i = 0;
            int a = 0;

            while (i <= 7)
            {
                Console.Write(chess[i, a]);
                a++;
                if (a > 7)
                {
                    Console.WriteLine(" ");
                    i++;
                    a = 0; 
                }
            }

            
            #endregion

            Console.ReadKey();
        }
    }
}
