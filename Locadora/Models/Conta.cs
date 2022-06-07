using System;

namespace Locadora.Models
{
    public class Conta
    {
        public int Saldo { get; private set; }

        public string ToString()
        {
            return "R$ " + Saldo + ",00";
        }

        public Conta(int saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Deposito(int valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(int valor)
        {
            Saldo = Saldo - valor;
        }
    }
}
