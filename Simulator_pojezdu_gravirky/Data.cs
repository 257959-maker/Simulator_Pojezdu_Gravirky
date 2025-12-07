using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_pojezdu_gravirky
{
    public struct Poloha
    {
        public double X { get; }
        public double Y { get; }

        public Poloha(double polohaX, double polohaY)
        {
            X = polohaX;
            Y = polohaY;
        }

        public override string ToString()
        {
            return $"[{X:F1}; {Y:F1}]";
        }
    }
}

