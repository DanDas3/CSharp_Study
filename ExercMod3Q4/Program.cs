using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod3Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat = 0;

            for (int i = 0; i <= 10; i++)
            {
                if(i == 0)
                {
                    fat = 1;
                } else
                {
                    fat = fat * i;
                }
            }
            Console.WriteLine("Fatorial de 10: " + fat);

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
