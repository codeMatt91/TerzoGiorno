using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class Salvadanaio
    {
        private int totale;
        internal int Add(int valore)
        {
            totale += valore;
            return totale;
        }

        public Salvadanaio()
        { 
            totale = 0;
        }

    }
}
