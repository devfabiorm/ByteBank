using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO MÉTODO MAIN.");
            }

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair");
            Console.ReadLine();
        }

        public static void CarregarContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //LeitorDeArquivos leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        public static void TentaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informações da INNER EXCEPTION (Exceção Interna):");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }

        }
    }
}
