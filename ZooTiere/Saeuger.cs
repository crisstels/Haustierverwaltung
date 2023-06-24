using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTiere
{
    public abstract class Saeuger : Haustier, IStreichelbar
    {
        public abstract void fortbewegen();

        // man kann auch Streicheln hier implementieren. Dann muss man nicht in den Kindklassen Streicheln implementieren
        public abstract void Streicheln();
    }
}
