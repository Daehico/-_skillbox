using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WaterTransport : TypeOfVechicles, IPassenger, IFuel
    {
        private string nameOfWaterTransport;
        public WaterTransport(string name,string fuel, string passenger, string nameOfWaterTransport)
            : base(name, fuel, passenger)
        {
            this.name = name;
            this.nameOfWaterTransport = nameOfWaterTransport;
            this.fuel = fuel;
            this.passenger = passenger;
        }
        public override void Move(TypeOfVechicles name)
        {
            Console.WriteLine("Существует множество видов транспорта. Например, {0} является водным транспортом", this.nameOfWaterTransport);
        }
        public string Fuel(TypeOfVechicles fuel)
        {
            string returntext;
            string text = fuel.ToString();
            if (text == "Использует")
            {
                returntext = "Данный транспорт использует топливо";
            }
            else
            {
                returntext = "Данный транспорт не использует топливо";
            }
            return returntext;
        }
        public string Passengers(TypeOfVechicles passenger)
        {
            string returntext2;
            string text = passenger.ToString();
            if (text == "Перевозит")
            {
                returntext2 = "Данный транспорт перевозит пассажиров";
            }
            else
            {
                returntext2 = "Данный транспорт не перевозит пассажиров";
            }
            return returntext2;
        }

    }
}
