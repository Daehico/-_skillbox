using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class TypeOfVechicles
    {
        protected string name;
        public string fuel; 
        public string passenger;
       



       public TypeOfVechicles (string name, string fuel, string passenger)
        {
            this.name = name;
            this.fuel = fuel;
            this.passenger = passenger;
        }

        public virtual  void Move(TypeOfVechicles name)
        {
            Console.WriteLine("Существует множество видов транспорта");
        }
    }
}
