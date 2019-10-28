using System;

namespace OrdemAlfab
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o primeiro nome: ");
            string nome = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Digite o segundo nome: ");
            string nome1 = Console.ReadLine();

            int compare = string.Compare(nome, nome1);

            if( compare < 0)
            {
                System.Console.WriteLine($"{nome} \n{nome1}");
            } else 
            {
                System.Console.WriteLine($"{nome1} \n{nome}");
            }
        }
    }
}
