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
                      
            var groundTtransport1 = new GroundTransport("Наземный транспорт", "Использует", "Перевозит","Автомобиль");
            var groundTtransport2 = new GroundTransport("Наземный транспорт", "Использует", "Перевозит", "Поезд");

           
            var waterTtransport1 = new WaterTransport("Вводный транспорт", "Использует", "Перевозит", "Пароход");
            var waterTtransport2 = new WaterTransport("Вводный транспорт", "Не использует", "Перевозит", "Лодка");

            
            var airTtransport1 = new AirTransport("Воздушный транспорт", "Использует", "Перевозит", "Самолеты");
            var airTtransport2 = new AirTransport("Воздушный транспорт", "Использует", "Перевозит", "Вертолеты");
            var airTtransport3 = new AirTransport("Воздушный транспорт", "Не использует", "Перевозит", "Дирижабли");
            var airTtransport4 = new AirTransport("Воздушный транспорт", "Не использует", "Не перевозит", "Квадракоптеры");


            

            Console.ReadKey();
        }
    }
}
