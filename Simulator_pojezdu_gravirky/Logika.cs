using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_pojezdu_gravirky
{
    public class Logika
    {
        public Poloha AktualniPoloha { get; private set; }

        private readonly PracovniPlocha _plocha;
        public List<Poloha> HistoriePohybu { get; }

        public Logika(PracovniPlocha plocha)
        {
            _plocha = plocha;
            AktualniPoloha = new Poloha(0, 0);
            HistoriePohybu = new List<Poloha> { AktualniPoloha };
        }

        public void PosunAbsolutne(double x, double y)
        {
            Poloha novaPozice = new Poloha(x, y);

           
            if (!_plocha.JeVLimitu(novaPozice))
            {
                throw new InvalidOperationException($"Chyba: Souřadnice {novaPozice} jsou mimo pracovní plochu!");
            }

           
            AktualniPoloha = novaPozice;
            HistoriePohybu.Add(novaPozice);

            Console.WriteLine($"-> Pohyb na {AktualniPoloha}");
        }

        public void PosunRelativne(double dx, double dy)
        {
            PosunAbsolutne(AktualniPoloha.X + dx, AktualniPoloha.Y + dy);
        }
    }
}
