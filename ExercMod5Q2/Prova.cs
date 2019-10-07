using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q2
{
    class Prova
    {
        private double notaParte1;
        private double notaParte2;

        public double NotaParte1 { get => notaParte1; set => notaParte1 = value; }
        public double NotaParte2 { get => notaParte2; set => notaParte2 = value; }

        public double CalcularNotaTotal()
        {
            return (notaParte1 + notaParte2) / 2;
        }
    }
}
