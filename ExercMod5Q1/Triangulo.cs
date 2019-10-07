using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q1
{
    class Triangulo
    {
        private double baseTri;
        private double alturaTri;
        private double areaTri;

        public double BaseTri { get => baseTri; set => baseTri = value; }
        public double AlturaTri { get => alturaTri; set => alturaTri = value; }
        public double AreaTri { get => areaTri; }

        public void CalculaArea()
        {
            areaTri = (baseTri * alturaTri) / 2;
        }
    }
}
