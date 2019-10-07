using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q1
{
    class Circunferencia
    {
        private double raio;
        private double areaCirc;
        public double Raio { get => raio; set => raio = value; }
        public double AreaCirc { get => areaCirc; }

        public void CalculaArea()
        {
            areaCirc = Math.PI * raio * raio;
        }
    }
}
