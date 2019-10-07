using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod7Q1
{
    class Ponto2D
    {
        double x;
        double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Ponto2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Imprimir()
        {
            Console.WriteLine("Coordenada 2D: (" + X + ", " + Y + ")");
        }
    }
}
