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
            var typeOfVechicles1 = new TypeOfVechicles("Наземный транспорт");
            var text1 = typeOfVechicles1.ToString();
            var groundTtransport1 = new GroundTransport(text1, "Автомобиль");
            var groundTtransport2 = new GroundTransport(text1, "Поезд");

            var typeOfVechicles2 = new TypeOfVechicles("Вводный транспорт");
            var text2 = typeOfVechicles2.ToString();
            var waterTtransport1 = new WaterTransport(text2, "Пароход");
            var waterTtransport2 = new WaterTransport(text2, "Лодка");

            var typeOfVechicles3 = new TypeOfVechicles("Воздушный транспорт");
            var text3 = typeOfVechicles3.ToString();
            var airTtransport1 = new AirTransport(text3, "Самолеты");
            var airTtransport2 = new AirTransport(text3, "Вертолеты");
            var airTtransport3 = new AirTransport(text3, "Дирижабли");
            var airTtransport4 = new AirTransport(text3, "Квадракоптеры");

            airTtransport1.Move(typeOfVechicles3);
            waterTtransport1.Move(typeOfVechicles2);
            groundTtransport1.Move(typeOfVechicles1);


            Console.ReadKey();
        }
    }
}
