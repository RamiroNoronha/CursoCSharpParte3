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
        public int NumeroAgencia { get; set; }
        public int NumeroConta { get; set; }
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
    }
}
