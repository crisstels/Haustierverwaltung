using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public class Haussschwein : Saeuger, IPflanzenfresser, IFleischfresser
    {
        // die implentierug von 2 Interfaces, die das gleiche vorgeben, führen beim Instanziieren der Klasse Hausschwein zu Problemen, da nicht bekannt ist
        // welchen Interface-Typ Hausschwein annimmt
        public override void fortbewegen()
        {
            Console.WriteLine($"Das Haussschwein {Name} rennt im Kreis");
        }

         void IFleischfresser.Fressen(string nahrung)
        {
            Console.WriteLine($"Das Hausschwein {Name} frisst {nahrung}");
        }

         void IPflanzenfresser.Fressen(string nahrung)
        {
            Console.WriteLine($"Das Hausschwein {Name} frisst {nahrung}");
        }

        public override void Pflegen()
        {
            Console.WriteLine($"Das Hausschwein {Name} wird gepflegt");
        }

        public override void Streicheln()
        {
            Console.WriteLine($"Das Hausschwein {Name} wird gestreichelt.");
        }
    }
}
