﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public class Goldfisch : Fisch, IStreichelbar
    {
        public Goldfisch(string name) { _Name = name; }
        public override void schwimmen()
        {
            Console.WriteLine($"Der Goldfisch {Name} schwimmt im Kreis");
        }

        public void Streicheln()
        {
            Console.WriteLine($"Der Goldfisch {Name} wird gestreichelt");
        }
    }
}
