using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod7Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Porta p = new Porta(2.5, 1.5, false);
            Porta p2;
            p2 = (Porta) p.Clone();
            p2.Abrir();

            Console.WriteLine("Altura: " + p.Altura + ", largura " + p.Largura + " estado: " + p.Aberta);
            Console.WriteLine("Altura: " + p2.Altura + ", largura " + p2.Largura + " estado: " + p2.Aberta);

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
