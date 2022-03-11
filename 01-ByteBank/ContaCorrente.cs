using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class ContaCorrente
    {
        private double _saldo;
        public Cliente Cliente { get; set; }
        public int NumeroAgencia { get;}
        public int NumeroConta { get;}
        public static int TotalDeContasCriandas { get; private set; }
        public static double TaxaDeOperacao { get; private set; }
        public double Saldo 
        {
            get
            {
                return _saldo;
            }
            private set
            {
                if(value < 0)
                {
                    Console.WriteLine("Valor atribuido para saldo é inválido!");
                    return;
                }
                    _saldo = value;
            } 
        }

        public ContaCorrente(int numAgencia, int numConta)
        {
            if(numAgencia <= 0)
            {
                throw new ArgumentException("O Argumento numAgencia precisa ser maior do que zero", nameof(numAgencia));
            }
            else if(numConta <= 0)
            {
                throw new ArgumentException("O Argumento numConta precisa ser maior do que zero", nameof(numConta));
            }
            NumeroAgencia = numAgencia;
            NumeroConta = numConta;

            TotalDeContasCriandas++;
            TaxaDeOperacao /= TotalDeContasCriandas;
        }

        public void Sacar(double valor)
        {
            if(valor > _saldo)
            {
                throw new SaldoInsuficienteException(valor, _saldo);
            }
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if(valor < 0)
            {

            }
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente conta)
        {
            if(valor < 0)
            {
                throw new SaldoInsuficienteException("Valor de tranferência inválido");
            }

            Sacar(valor);
            Depositar(valor);
        }

    }
}
