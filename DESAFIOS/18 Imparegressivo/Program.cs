using System;

namespace Imparegressivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para mostrar os numeros imapares regressivos");
            Console.WriteLine("Digite o numero desejado:");
            for (int i = 1; i <= 500; i+=2)
            { 
                System.Console.Write(" " + i);
            } 
        }
    }
}
