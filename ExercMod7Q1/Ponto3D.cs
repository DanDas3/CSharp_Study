using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod7Q1
{
    class Ponto3D : Ponto2D
    {
        double z;

        public double Z { get => z; set => z = value; }

        public Ponto3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public void Imprimir()
        {
            Console.WriteLine("Coordenada 2D: (" + X + ", " + Y + ", " + Z + ")");
        }
    }
}
