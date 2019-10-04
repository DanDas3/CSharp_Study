using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double peso;
            double media=0;
            double totalPeso=0;

            do
            {
                Console.WriteLine("Insira a nota:");
                nota = double.Parse(Console.ReadLine());

                if(nota != -1)
                {
                    Console.WriteLine("Insira o peso:");
                    peso = double.Parse(Console.ReadLine());

                    media += (nota * peso);

                    totalPeso += peso;

                    
                } else
                {
                    Console.WriteLine("Média: " + media / totalPeso);
                }

            } while (nota != -1);

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
