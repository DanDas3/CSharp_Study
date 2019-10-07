using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod4Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Relogio r = new Relogio();

            r.AcertarRelogio(11, 16, 55);

            Console.WriteLine("Hora: " + r.LerHora() + "Minuto: " + r.LerMinuto() + "Segundo " + r.LerSegundo());

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
