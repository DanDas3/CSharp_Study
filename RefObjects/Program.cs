using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Carro c2 = new Carro();
            Carro c3;

            c1.Placa = "ABC-1234";
            c1.Cor = "Amarelo";
            c1.Ano = 2013;

            c2.Placa = "DEF-5678";
            c2.Cor = "Preto";
            c2.Ano = 2016;

            c3 = c1;

            c3.Cor = "Azul";

            Console.WriteLine("Cor carro 1: " + c1.Cor);
            Console.WriteLine("Cor carro 2: " + c2.Cor);
            Console.WriteLine("Cor carro 3: " + c3.Cor);

            Console.ReadLine();
        }
    }
}
