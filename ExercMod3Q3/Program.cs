using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 10; i < 26; i++)
            {
                Console.Write(i + "");
                Console.WriteLine();
            }

            for (int i = 1; i <= 100; i++)
            {
                if(i%2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("Soma: " + soma);

            soma = 0;

            for (int i = 0; i < 101; i++)
            {
                soma += i;
                if(soma <100)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("9 x " + i + " = " + i*9);
            }

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
