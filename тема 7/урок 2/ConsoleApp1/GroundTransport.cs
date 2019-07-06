using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class GroundTransport : TypeOfVechicles
    {
        private string nameOfGroundTransport;
        public GroundTransport(string name, string nameOfGroundTransport) 
            : base(name)
        {
            this.name = name;
            this.nameOfGroundTransport = nameOfGroundTransport;
        }
        public override void Move(TypeOfVechicles name)
        {
            Console.WriteLine("Существует множество видов транспорта. Например, {0} является наземным транспортом", this.nameOfGroundTransport);
        }
    }
}
