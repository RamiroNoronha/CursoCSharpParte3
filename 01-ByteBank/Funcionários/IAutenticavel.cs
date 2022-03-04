using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionários
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
