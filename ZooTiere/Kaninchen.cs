using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public class Kaninchen : Saeuger, IPflanzenfresser
    {

        public Kaninchen(string name, string besitzer)
        {
            _Name = name;
            _Besitzer = besitzer;
        }
        public override void fortbewegen()
        {
            Hoppeln();
        }

        public void Fressen(string nahrung)
        {
            Console.WriteLine($"Das Kaninchen {Name} frisst {nahrung}");
        }

        public override void Pflegen()
        {
            StallAusmisten();
        }

        public override void Streicheln()
        {
            Console.WriteLine($"Das Kaninchen {Name} wird gestreichelt");
        }

        private void Hoppeln()
        {
            Console.WriteLine($"Das Kaninchen {Name} hoppelt");
        }

        private void StallAusmisten()
        {
            Console.WriteLine($"Der Stall von {Name} wird ausgemistet");
        }
    }
}
