using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum statusOrder
        {

            FormationOfTheOrder,
            WaitingForPayment,
            Delivery,
            Delivered

        }
        static void Main(string[] args)
        {

            String[,] order = new string[8, 2];
            order[0, 0] = 0.ToString();
            order[0, 1] = statusOrder.FormationOfTheOrder.ToString();

            order[1, 0] = 1.ToString();
            order[1, 1] = statusOrder.Delivered.ToString();

            order[2, 0] = 2.ToString();
            order[2, 1] = statusOrder.Delivery.ToString();

            order[3, 0] = 3.ToString();
            order[3, 1] = statusOrder.WaitingForPayment.ToString();

            order[4, 0] = 4.ToString();
            order[4, 1] = statusOrder.Delivery.ToString();

            order[5, 0] = 5.ToString();
            order[5, 1] = statusOrder.Delivered.ToString();

            order[6, 0] = 6.ToString();
            order[6, 1] = statusOrder.WaitingForPayment.ToString();

            order[7, 0] = 7.ToString();
            order[7, 1] = statusOrder.FormationOfTheOrder.ToString();

            Console.WriteLine("Ввдите,пожалуйста, номер Вашего заказа");
            var writeId = Console.ReadLine();

            string id = writeId.ToString();

            
                int number;
                bool result = Int32.TryParse(id, out number);
                if (result)
                {
                    if (number < 7)
                    {
                  

                    var a = order[number, 1];
                    var b = "FormationOfTheOrder";
                    var c = "WaitingForPayment";
                    var d = "Delivery";
                    var e = "Delivered";

                    if (a == b)
                    {
                        Console.WriteLine("Cтатус вашего заказа: формирование заказа");
                    }
                    else if (a == c)
                    {
                        Console.WriteLine("Cтатус вашего заказа: Ожидание оплаты заказа");
                    }

                    else if (a == d)
                    {
                        Console.WriteLine("Cтатус вашего заказа: Доставка");
                    }

                    else if (a == e)
                    {
                        Console.WriteLine("Cтатус вашего заказа: Доставлен");
                    }
                    else
                    {
                        Console.WriteLine("Заказ под таким номером не обнаружен. Пожалуйста, проверьте правильность введенного номера заказа");
                    }
                }

            }


             

                Console.ReadKey();
            }
        }
    }


