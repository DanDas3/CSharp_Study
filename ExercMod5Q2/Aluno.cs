using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q2
{
    class Aluno
    {
        private Prova prova1;
        private Prova prova2;

        internal Prova Prova1 { get => prova1; set => prova1 = value; }
        internal Prova Prova2 { get => prova2; set => prova2 = value; }

        public double CalcularMedia()
        {
            return (prova1.CalcularNotaTotal() + prova2.CalcularNotaTotal()) / 2;
        }
    }
}
