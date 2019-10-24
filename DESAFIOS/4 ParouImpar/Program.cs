
using System;

namespace parouimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

                Console.Write("Digite um número inteiro: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0){
                    Console.WriteLine("É par");
                } else {
                    Console.WriteLine("É impar");
                }
        }
    }
}

