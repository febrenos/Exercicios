using System;
using System.Collections.Generic;
using bytebank2.Models;

namespace bytebank2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrent contaCorrente1 = new ContaCorrente(1, 1, "Alexandre");      // construtor da conta corrente
            ContaCorrent contaCorrente2 = new ContaCorrente(1, 2, "Alexandre");     // construtor da conta corrente

            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);

            ContaEspecial contaEspecial = new ContaEspecial(1, 2, "cesar");
            contaEspecial1.SetLimite(1000);                                          
            DepositarConta(contaEspecial1);
            sacarConta(contaEspecial1);
        }
        public static void DepositarConta(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Bytebank - Deposito");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine($"conta: {contaBancaria.GetType()}");
            Console.WriteLine($"Bem Vindo! - {usuario}");
            Console.WriteLine($"Agencia: {conta1.Agencia}   conta: {conta1.NumeroConta}");
            Console.WriteLine($"Saldo origem: {conta1.Saldo}");
            Console.WriteLine($"Saldo destino: {conta2.Saldo}");
            Console.WriteLine("Digite o valor da transferencia: ");
            double valor = double.Parse(Console>ReadLine());

            if(contaBancaria.Transferencia(conta2, valor))
            {
                Console.WriteLine("Tranferencia efetuada com sucesso.");
                Console.WriteLine($"Saldo origem: {conta1.Saldo}");
                Console.WriteLine($"Saldo destino: {conta1.Saldo}");
            }
            else
            {
                Console.WriteLine("Operação não pode ser realizada.");
                Console.WriteLine("Por favor tente novamente.");
            }
            Console.WriteLine($"Saldo origem: {contaCorrente.Saldo}");
            Console.WriteLine($"Saldo destino: {contaCorrente2.Saldo}");
        }
    }
}
