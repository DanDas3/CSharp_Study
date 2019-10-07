using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod7Q2
{
    class Porta : ICloneable
    {
        private double altura;
        private double largura;
        private bool aberta;

        public Porta(double altura, double largura, bool aberta)
        {
            this.altura = altura;
            this.largura = largura;
            this.aberta = aberta;
        }

        public double Altura { get => altura; }
        public double Largura { get => largura; }
        public bool Aberta { get => aberta; }

        public void Abrir()
        {
            this.aberta = true;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Fechar()
        {
            this.aberta = false;
        }
    }
}
