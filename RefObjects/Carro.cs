using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefObjects
{
    class Carro
    {
        string placa;
        int ano;
        string cor;

        public Carro()
        {

        }

        public Carro(string placa, int ano, string cor)
        {
            this.placa = placa;
            this.ano = ano;
            this.cor = cor;
        }

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Cor { get => cor; set => cor = value; }
    }
}
