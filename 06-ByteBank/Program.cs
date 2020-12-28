using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Fabio";
            cliente.CPF = "123.123.123.12";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;

            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);

            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
