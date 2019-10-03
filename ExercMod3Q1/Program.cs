using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double peso;
            double totalPeso = 0;
            double media = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Insir a nota:");
                nota = double.Parse(Console.ReadLine());

                Console.WriteLine("Insir o peso:");
                peso = double.Parse(Console.ReadLine());

                media += (nota * peso);
                totalPeso += peso;
            }

            Console.WriteLine("Média: " + media/totalPeso);

            Console.ReadLine();

        }
    }
}
