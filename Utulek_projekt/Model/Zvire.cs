using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utulek_projekt.Model
{
    internal class Zvire
    {
        public int Id {  get; set; }
        public string Jmeno { get; private set; }
        public string Druh { get; private set; }
        public int Vek { get; private set; }
        public string Pohlavi { get; private set; } = 0;
        public bool Adoptovano { get; private set; } = false;
    }
}
