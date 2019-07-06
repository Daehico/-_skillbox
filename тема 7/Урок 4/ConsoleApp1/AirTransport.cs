using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AirTransport : TypeOfVechicles, IPassenger, IFuel
    {
        private string nameOfAirTransport;
        public AirTransport(string name, string fuel, string passenger, string nameOfAirTransport)
            : base(name, fuel, passenger)
        {
            this.name = name;
            this.nameOfAirTransport = nameOfAirTransport;
            this.fuel = fuel;
            this.passenger = passenger;
        }

        public string Fuel(TypeOfVechicles fuel)
        {
            string returntext;
            string text = fuel.ToString();
            if(text == "Использует")
            {
                returntext = "Данный транспорт использует топливо";
            }
            else
            {
                returntext = "Данный транспорт не использует топливо";
            }
            return returntext;
        }

        public override void Move(TypeOfVechicles name)
        {
            Console.WriteLine("Существует множество видов транспорта. Например, {0} является воздушным транспортом", this.nameOfAirTransport);
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
