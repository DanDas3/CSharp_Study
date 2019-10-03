using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Random m = new Random(4);

            int aleat;

            int num;

            aleat = m.Next()%10;
            Console.WriteLine(aleat);
            Console.WriteLine("Vamos começar a brincadeira");
            do
            {
                Console.WriteLine("Insira um valor entre 0 e 9:");
                num = Console.Read() - 48;
                Console.Read();
                Console.WriteLine(num);
                Console.WriteLine( aleat);
                if(num == aleat)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                } else
                {
                    Console.WriteLine("Que pena! Boa sorte na próxima");
                }
            }
            while (num != aleat) ;
            Console.Read();
            Console.Read();
        }
    }
}
