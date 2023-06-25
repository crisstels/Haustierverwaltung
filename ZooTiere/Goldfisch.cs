using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public class Goldfisch : Fisch, IStreichelbar
    {
        public Goldfisch(string name, string besitzer)
        {
            _Name = name;
            _Besitzer = besitzer;
        }
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
