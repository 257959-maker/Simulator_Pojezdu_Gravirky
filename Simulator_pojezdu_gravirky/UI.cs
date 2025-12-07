using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_pojezdu_gravirky
{
    public class UI
    {
        private readonly Logika _laser;

        public UI(Logika laser)
        {
            _laser = laser;
        }

        public void SpustitInterakci()
        {
            Console.WriteLine("Příkazy: 'abs X Y', 'rel X Y', 'exit'");

            bool bezi = true;
            while (bezi)
            {
                Console.Write("\n> ");
                string vstup = Console.ReadLine();

                string[] casti = vstup?.Split(' ');

                try
                {
                    if (casti != null && casti.Length > 0)
                    {
                        ZpracujPrikaz(casti, ref bezi);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Chyba: Zadávejte pouze čísla!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CHYBA: {ex.Message}");
                }
            }
        }

        private void ZpracujPrikaz(string[] casti, ref bool bezi)
        {
            switch (casti[0].ToLower())
            {
                case "abs":
                    if (casti.Length == 3)
                        _laser.PosunAbsolutne(double.Parse(casti[1]), double.Parse(casti[2]));
                    else
                        Console.WriteLine("Použití: abs [X] [Y]");
                    break;

                case "rel":
                    if (casti.Length == 3)
                        _laser.PosunRelativne(double.Parse(casti[1]), double.Parse(casti[2]));
                    else
                        Console.WriteLine("Použití: rel [dX] [dY]");
                    break;

                case "exit":
                    bezi = false;
                    break;

                default:
                    Console.WriteLine("Neznámý příkaz.");
                    break;
            }
        }
    }
}