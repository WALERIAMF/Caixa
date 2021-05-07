using Caixa.Domain.Model;
using System;
using System.Collections.Generic;

namespace Caixa.Domain
{
    public class ContaCorrente : IEntity
    {
        public int Id { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public List<ContaCorrenteCliente> ContaCorrenteCliente { get; set; }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public void Depositar(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Valor depositado deve ser maior que 0", nameof(valor));
            }

            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Valor do saque maior que zero", nameof(valor));
            }

            if(valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }
}
