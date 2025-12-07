using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_pojezdu_gravirky
{
    public class PracovniPlocha
    {
        public double Sirka { get; }
        public double Vyska { get; }

        public PracovniPlocha(double sirka, double vyska)
        {
            Sirka = sirka;
            Vyska = vyska;
        }


        public bool JeVLimitu(Poloha p)
        {
            return p.X >= 0 && p.X <= Sirka && p.Y >= 0 && p.Y <= Vyska;
        }
    }
}
