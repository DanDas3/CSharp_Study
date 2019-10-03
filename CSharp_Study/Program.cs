using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            System.Int64 a = 0, b = 0;

            short c;

            a = 100000;
            c = (short)a; // Casting explícito 

            Console.WriteLine(c);
        }
    }
}
