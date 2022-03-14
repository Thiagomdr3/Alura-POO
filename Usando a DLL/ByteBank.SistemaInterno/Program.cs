using Excecoes;
using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(554,321);
            conta.Depositar(50);
            Console.WriteLine(conta.Saldo);
            DateTime data = new DateTime();  

           
            
        }
    }
}
