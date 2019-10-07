using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q2
{
    class Turma
    {
        private Aluno aluno1;
        private Aluno aluno2;
        private Aluno aluno3;

        internal Aluno Aluno1 { get => aluno1; set => aluno1 = value; }
        internal Aluno Aluno2 { get => aluno2; set => aluno2 = value; }
        internal Aluno Aluno3 { get => aluno3; set => aluno3 = value; }

        public double CalcularMedia()
        {
            return (aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia()) / 3;
        }
    }
}
