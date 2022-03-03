using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionários
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
