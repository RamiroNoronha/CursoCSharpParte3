using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class SaldoInsuficienteException : Exception
    {
        public double ValorSaque { get; }
        public double ValorSaldo { get; }
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(double valorSaque, double valorSaldo) :
            this("Tentativa de retirada no valor de " + valorSaque + " em uma conta com saldo de " + valorSaldo)
        {
            ValorSaque = valorSaque;
            ValorSaldo = valorSaldo;
        }

        public SaldoInsuficienteException(string mensage) : base(mensage)
        {

        }
    }
}
