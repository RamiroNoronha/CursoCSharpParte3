using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionários
{
    public interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
