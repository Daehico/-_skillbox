using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AirTransport : TypeOfVechicles
    {
        private string nameOfAirTransport;
        public AirTransport(string name, string nameOfAirTransport)
            : base(name)
        {
            this.name = name;
            this.nameOfAirTransport = nameOfAirTransport;
        }
    }
}
