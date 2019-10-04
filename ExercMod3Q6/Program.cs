using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod3Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            while(x < 1000)
            {
                if(x%2 == 0)
                {
                    x = x + 5;
                } else
                {
                    x = x * 2;
                }
                Console.WriteLine(x + " ");
            }

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
