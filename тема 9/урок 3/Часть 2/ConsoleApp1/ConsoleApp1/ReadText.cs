using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReadText
    {
        public static string text;
        public static string TextReader()
        {
            Console.WriteLine("Введите въехать на стоянку или покинуть стоянку");
             text = Console.ReadLine();
        return text;
    }
        
        public static Stack<string> textQueue = new Stack<string>();
        public static int id = textQueue.Count;
        public static string a;

        public static string Text()
        {
            if(id <= 5 )
            {
                TextCount();
                if (text == "Въехать на стоянку")
                {
                    textQueue.Push(text);
                    a = "Самолет №" + id + " въехал на стоянку";
                    TextCount();
                }
                else if (text == "Покинуть стоянку")
                {
                    TextCount();
                    textQueue.Pop();
                    a = "Самолет №" + id + " покинул стоянку";
                    TextCount();
                }
                else
                {
                    Console.WriteLine("Введите въехать на стоянку или покинуть стоянку");
                    TextReader();
                }

            }
         
            else
            {
                if (text == "Въехать на стоянку")
                {
                   
                    a = "Размещение самолетов на стоянку приостановлен";
                    TextCount();
                }
                else if (text == "Покинуть стоянку")
                {
                    TextCount();
                    textQueue.Pop();
                    a = "Самолет №" + id + " покинул стоянку";
                    TextCount();
                }
                else
                {
                    Console.WriteLine("Введите въехать на стоянку или покинуть стоянку");
                    TextReader();
                }
            }
            TextCount();
            return a;
        }

        public static int TextCount()
        {
            id = textQueue.Count;
            return id;
        }
        
   }
       
    }

