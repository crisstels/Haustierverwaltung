using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public abstract class Fisch : Haustier
    {
        public abstract void schwimmen();

        // ohne override wird Methode überladen
        public override void Pflegen()
        {
            WasserWechseln();
        }

        private void WasserWechseln()
        { 
            Console.WriteLine($"Das Wasser für {Name} wird gewechselt.");
        }
    }
}
