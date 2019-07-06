using System;

namespace PaymentConsole
{
    /// <summary>
    /// Модель платежного терминала
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main(string[] args)
        {
            // Параметры программы
            var limit = 10000; // Допустимый лимит, рублей
            var serviceFee = 5; // Размер комиссии, %

            Console.WriteLine("Взимается комиссия {0}%", serviceFee);
            Console.Write("Введите сумму для пополнения счёта: ");

            var sumString = Console.ReadLine();

            /*
                1. Преобразуем строку в число
                2. Если введенная строка является числом и оно больше нуля, то
                2.1. если лимит превышен, выдаем соответствующее сообщение
                2.2. иначе рассчитываем комиссию и сообщаем об успешном платеже
            */

            double sum;
            var success = double.TryParse(sumString, out sum);

            if (success && sum > 0)
            {
                if (sum > limit)
                {
                    Console.WriteLine("Введенная сумма превышает допустимый лимит ({0} р.)", limit);
                }
                else
                {
                    var feeValue = sum * serviceFee / 100;
                    Console.WriteLine("Платеж проведен успешно.");
                    Console.WriteLine("Комиссия составила {0} р.", feeValue);

                    Console.Write("Введите промокод: ");
                    var promoCode = Console.ReadLine();

                   switch (promoCode)
                    {
                        case "12345":
                            Console.WriteLine("Вам начислен бонус 1000 рублей");
                            break;
                        case "278967":
                            Console.WriteLine("Вам начислен бонус 1500 рублей");
                            break;
                        case "980897":
                            Console.WriteLine("Вам начислен бонус 2000 рублей");
                            break;
                     
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
