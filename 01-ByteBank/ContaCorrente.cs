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
            set
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
    }
}
