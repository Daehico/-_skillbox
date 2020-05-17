using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace timer
{
    class Program
    {
        private static bool timerWorkOrNot = false;
        private static Thread thread = new Thread(new ThreadStart(StartTimer));
        private static int seconds;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пробел что бы начать или остановить секундомер");

            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar)
                {
                    timerWorkOrNot = TimerWork(timerWorkOrNot);
                }
            }
        }

        private static bool TimerWork(bool timerWorkOrNot)
        {
            if (timerWorkOrNot == false)
            {
                thread.Start();
                timerWorkOrNot = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Нажмите пробел что бы начать таймер");
                timerWorkOrNot = false;
                thread.Abort();
                thread = new Thread(new ThreadStart(StartTimer));

            }
            return timerWorkOrNot;

        }

        private static void StartTimer()
        {    
            seconds = 0;
            while (timerWorkOrNot == true)
            {
                seconds++;
                Console.WriteLine("Прошло секунд:" + seconds);
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Введите пробел что бы остановить таймер");    

            }

        }

    }
}
