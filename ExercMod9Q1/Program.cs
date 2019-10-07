using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod9Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria(100.0);

            ContaBancaria c2 = new ContaBancaria(50.0);

            try
            {
                c1.Depositar(-20.5);
            }
            catch (Exception e)
            {

                
            }
        }
    }
}
