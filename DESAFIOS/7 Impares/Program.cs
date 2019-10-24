using System;

namespace numero_par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do{
                Console.Write("Digite um número inteiro ou zero para parar:");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0){
                    Console.WriteLine("O número é par");
                } else {
                    Console.WriteLine("O número é impar");
                }
            }while(num != 0);
        }
    }
}