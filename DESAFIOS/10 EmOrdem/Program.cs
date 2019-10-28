using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("É OU NÃO MULTIPLO DE 3? ");
            Console.WriteLine("Digite um número:");
        for (int i = 1; i <= 100
                ; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("o numero " + i +"é" + "multiplo de 3");
                    Console.ReadLine();
                }
            }
        }
    }
}

