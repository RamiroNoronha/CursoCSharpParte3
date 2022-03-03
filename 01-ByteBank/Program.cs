using _01_ByteBank.Funcionários;
using _01_ByteBank.Sistemas;
using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("123.456.789-12");
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

            GerenteDeConta gabriel = new GerenteDeConta("123.456.098-12");
            gabriel.Senha = "abc";

            sistemaInterno.Logar(gabriel, "abc");

            Design pricila = new("123.432.131-12");

        }
    }

}
