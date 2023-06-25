using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public class Katze : Saeuger, IFleischfresser
    {
        public Katze(string name, string besitzer) { 
            _Name = name;
            _Besitzer = besitzer;
        }
        public override void fortbewegen()
        {
            Schleichen();
        }

        public override void Pflegen()
        {
            FellBürsten();
        }

        public override void Streicheln()
        {
            Console.WriteLine($"Díe Katze {Name} wird gestreichelt");
            Schnurren();
        }

        private void Schleichen()
        {
            Console.WriteLine($"Die Katze {Name} schleicht");
        }

        private void FellBürsten()
        {
            Console.WriteLine($"Das Fell der Katze {Name} wird gebuerstet");
        }

        private void Schnurren()
        {
            Console.WriteLine($"Die Katze {Name} schnurrt");
        }

        public void Fressen(string nahrung)
        {
            Console.WriteLine($"Die Katze {Name} frisst {nahrung}");
        }
    }
}
