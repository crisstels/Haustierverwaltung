using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public class Katze : Saeuger
    {
        public Katze(string name) { 
            Name = name;
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
        }

        private void Schleichen()
        {
            Console.WriteLine($"Die Katze {Name} schleicht");
        }

        private void FellBürsten()
        {
            Console.WriteLine($"Das Fell der Katze {Name} wird gebuerstet");
        }
    }
}
