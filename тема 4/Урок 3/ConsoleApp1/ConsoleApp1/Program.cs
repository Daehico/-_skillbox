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
            string text = Console.ReadLine();

            var a = text.Substring(0, Math.Min(150, text.Length));
            Console.WriteLine(a);
            var values = a.Split(' ', ',', '.', '?', '!');
            string wordWithMaxLength = string.Empty;
            Console.WriteLine("Самое длинное слово:" + values.Length);

            for (int i = 0; i < values.Length; i++)
                if (values[i].Length > wordWithMaxLength.Length)
                    wordWithMaxLength = values[i];
            Console.WriteLine("Самое длинное слово:" + wordWithMaxLength);

            var textResult = method(text);
            Console.WriteLine(textResult);

            Console.ReadKey();
           

        }
        static string method(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' });
            string result;

            var chetnii = 0;
            var nechetnii = 0;
            foreach (var a in words)
            {
                var b = a.Length;
                var c = b % 2;



                if (c == 0)
                {
                    chetnii++;
                }
                else
                {
                    nechetnii++;
                }
            }
            if (chetnii > nechetnii)
            {
                result = "Количество четных слов больше, чем нечетных. Количество четных слов:" + chetnii.ToString();
            }
            else
            {
                result = "Количество нечетных слов больше, чем четных. Количество нечетных слов:" + chetnii.ToString();
            }


            return result;
        }
        
    }
}
