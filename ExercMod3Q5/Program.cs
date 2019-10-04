using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod3Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci de 10: " + Fib(10));

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }

        static int Fib(int x)
        {
            if(x == 0)
            {
                return 0;
            } else if (x == 1)
            {
                return 1;
            } else
            {
                return Fib(x - 1) + Fib(x - 2);
            }
        }
    }
}
