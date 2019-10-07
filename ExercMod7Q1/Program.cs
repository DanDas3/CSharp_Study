using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod7Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto2D point1 = new Ponto2D(3.0, 5.0);
            Ponto3D point2 = new Ponto3D(3.0, 5.0, 7.0);

            point1.Imprimir();
            point2.Imprimir();

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
