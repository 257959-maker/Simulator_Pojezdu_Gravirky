using Simulator_pojezdu_gravirky;
using System;

namespace Simulator_pojezdu_gravirky
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GRAVÍRKA (V1) ===");

            // Nastaveni plochy
            PracovniPlocha plocha = new PracovniPlocha(200, 200);
            Logika laser = new Logika(plocha);

            // Predani
            UI uzivatelskeRozhrani = new UI(laser);

            Console.WriteLine($"Plocha nastavena na: {plocha.Sirka}x{plocha.Vyska}");

            // Ovladani
            uzivatelskeRozhrani.SpustitInterakci();
        }
    }
}

