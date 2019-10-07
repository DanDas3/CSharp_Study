using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q1
{
    class Quadrado
    {
        private double lado;
        private double areaQuad;

        public double Lado { get => lado; set => lado = value; }
        public double AreaQuad { get => areaQuad; }

        public void CalculaArea()
        {
            areaQuad = lado * lado;
        }
    }
}
