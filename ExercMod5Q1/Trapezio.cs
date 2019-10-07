using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q1
{
    class Trapezio
    {
        private double baseMenor;
        private double baseMaior;
        private double alturaTrap;
        private double areaTrap;

        public double BaseMenor { get => baseMenor; set => baseMenor = value; }
        public double BaseMaior { get => baseMaior; set => baseMaior = value; }
        public double AlturaTrap { get => alturaTrap; set => alturaTrap = value; }
        public double AreaTrap { get => areaTrap; }

        public void CalculaArea()
        {
            areaTrap = ((baseMaior + baseMenor) / 2) * alturaTrap;
        }
    }
}
