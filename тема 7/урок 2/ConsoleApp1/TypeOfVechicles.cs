﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TypeOfVechicles
    {
        protected string name;
        
       public TypeOfVechicles (string name)
        {
            this.name = name;
        }

        public virtual  void Move(TypeOfVechicles name)
        {
            Console.WriteLine("Существует множество видов транспорта");
        }
    }
}
