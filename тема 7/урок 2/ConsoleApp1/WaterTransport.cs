using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WaterTransport : TypeOfVechicles
    {
        private string nameOfWaterTransport;
        public WaterTransport(string name, string nameOfWaterTransport)
            : base(name)
        {
            this.name = name;
            this.nameOfWaterTransport = nameOfWaterTransport;
        }
        public override void Move(TypeOfVechicles name)
        {
            Console.WriteLine("Существует множество видов транспорта. Например, {0} является водным транспортом", this.nameOfWaterTransport);
        }
    }
}
