using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionários
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Salario = salario;
            CPF = cpf;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
