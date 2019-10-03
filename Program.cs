using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            string oper;



            Console.WriteLine("Digite o 1º número:");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º número:");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4º número:");
            nota4 = int.Parse(Console.ReadLine());

            media = nota1 + nota2 + nota3 + nota4 /4;

            Console.writeLine("sua média é" + media)

            Console.WriteLine($"{num1} + {num1} + {num1} + {num1} = {num1 + num2 + num1 + num2}");
            Console.WriteLine($"{num1} - {num1} - {num1} - {num1} = {num1 - num2 - num1 - num2}");
            Console.WriteLine($"{num1} * {num1} * {num1} * {num1} = {num1 * num2 * num1 * num2}");
            Console.WriteLine($"{num1} / {num1} / {num1} / {num1} = {num1 / num2 / num1 / num2}");
            Console.WriteLine($"{num1} % {num1} % {num1} % {num1} = {num1 % num2 % num1 % num2}");
        }
    }
} 
