using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod9Q1
{
    class ContaBancaria
    {
        private double saldo;

        public ContaBancaria(double saldo)
        {
            this.saldo = saldo;
        }

        public double Saldo { get => saldo; set => saldo = value; }

        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new ValorInvalidoException("Valor de saque incorreto: valor nulo ou negativo");
            }

            if(valor > saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente!");
            }

            this.saldo = this.saldo - valor;
        }

        public void Depositar(double valor)
        {
            if(valor <= 0)
            {
                throw new ValorInvalidoException("Valor de saque incorreto: valor nulo ou negativo");
            }
        }

        public void Transferir(double valor, ContaBancaria dst)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor de saque incorreto: valor nulo ou negativo");
            }

            if (valor > saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente!");
            }

            this.Sacar(valor);
            dst.Depositar(valor);
        }
    }
}
