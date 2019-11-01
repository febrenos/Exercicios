using System;

namespace Verbo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================");
            Console.WriteLine("=  AR, ER, IR  =");
            Console.WriteLine("================");
            Console.WriteLine();

            System.Console.WriteLine("Digite o primeiro Verbo: ");
            string nome = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Digite o segundo Verbo: ");
            string nome1 = Console.ReadLine();
            System.Console.WriteLine("Digite o terceiro Verbo: ");
            string nome2 = Console.ReadLine();

            int compare = string.Compare(nome, nome1);

            if( compare < 0)
            {
                System.Console.WriteLine($"{nome} {nome1}\n");
            } else 
            {
                System.Console.WriteLine($"{nome1} {nome}\n");
            }
        }
    }
}