using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;


            Console.WriteLine("Digite o 1º número:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º número:");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4º número:");
            nota4 = double.Parse(Console.ReadLine());

            media = nota1 + nota2 + nota3 + nota4 /4;

            Console.writeLine("sua média é" + media);

            else if(oper== "+"){
                Console.WriteLine($"{num1} + {num2} + {num3} + {num4} = {num1 + num2 + num3 + num4}");
                break
            }
            else if(oper== "+"){
                Console.WriteLine($"{num1} - {num2} - {num3} - {num4} = {num1 - num2 - num3 - num4}");
                break
            }
            else if(oper== "+"){
                Console.WriteLine($"{num1} * {num2} * {num3} * {num4} = {num1 * num2 * num3 * num4}");
                break
            }
            else if(oper== "+"){
                 Console.WriteLine($"{num1} / {num2} / {num3} / {num4} = {num1 / num2 / num3 / num4}");
                 break
            }
            else if(oper== "+"){
                Console.WriteLine($"{num1} % {num2} % {num3} % {num4} = {num1 % num2 % num3 % num4}");
                break
            }
        }
    }
} 
