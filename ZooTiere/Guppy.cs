using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public class Guppy : Fisch
    { 
        public Guppy(string name) { _Name = name; }  
        public override void schwimmen()
        {
            Console.WriteLine($"Der Guppy {Name} schwimmt hin und her");
        }
    }
}
