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

            List<string> stations = new List<string>();
            List<string> transport = new List<string>();

            string a = "станция № 1";
            string b = "станция № 2";

            string c = "Автобус";
            string d = "Поезд";

          
                stations.Add(a);
                stations.Add(b);
                stations.Sort();
                      
                transport.Add(c);
                transport.Add(d);
            transport.Sort();

            string stringstation1 = stations[0].ToString();
            string stringstation2 = stations[1].ToString();

            string stringtransport1 = transport[0].ToString();
            string stringtransport2 = transport[1].ToString();


            var e = Station<Bus>.Accept(stringtransport1, stringstation1);
            var f = Station<Train>.Accept(stringtransport2, stringstation2);

            var g = Station<Bus>.Send(stringtransport1, stringstation1);
            var h = Station<Train>.Send(stringtransport2, stringstation2);

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.ReadKey();
        }
    }

    public enum Bus
    {
    
    }

    enum Train
    {
    }
}
