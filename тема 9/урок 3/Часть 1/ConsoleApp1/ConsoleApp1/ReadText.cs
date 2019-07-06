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
            Console.WriteLine("Введите Разместить заказ или Выполнить заказ");
             text = Console.ReadLine();
        return text;
    }
        
        public static Queue<string> textQueue = new Queue<string>();
        public static int id = textQueue.Count;
        public static string a;

        public static string Text()
        {
            if(id <= 10 )
            {
                TextCount();
                if (text == "Разместить заказ")
                {
                    textQueue.Enqueue(text);
                    a = "Заказ №" + id + " размещен";
                    TextCount();
                }
                else if (text == "Выполнить заказ")
                {
                    TextCount();
                    textQueue.Dequeue();
                    a = "Заказ №" + id + " выполнен";
                    TextCount();
                }
                else
                {
                    Console.WriteLine("Введите разместить заказ или Выполнить заказ");
                    TextReader();
                }

            }
         
            else
            {
                if (text == "Разместить заказ")
                {
                   
                    a = "Размещение заказов приостановлен";
                    TextCount();
                }
                else if (text == "Выполнить заказ")
                {
                    TextCount();
                    textQueue.Dequeue();
                    a = "Заказ №" + id + " выполнен";
                    TextCount();
                }
                else
                {
                    Console.WriteLine("Введите разместить заказ или Выполнить заказ");
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

