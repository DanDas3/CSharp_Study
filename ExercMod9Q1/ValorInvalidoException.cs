using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod9Q1
{
    class ValorInvalidoException : Exception
    {
        public ValorInvalidoException(string mensagem) : base(mensagem){ }
    }
}
