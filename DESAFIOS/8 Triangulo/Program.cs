using System;
using System.Collections.Generic;
using System.Text;

namespace PiramideAsteriscos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos criar uma pirâminde?");
            inicio:
            Console.WriteLine("insira seu lado maior:");
            try
            {
                int nivel = int.Parse(Console.ReadLine());
                if (nivel != 0) // se a base for diferente de 0, se for 0 ele para
                {

                    int a;
                    int espacos;
                    for (int i = nivel; i >= 1; i--)
                    {
                        StringBuilder final = new StringBuilder();

                        espacos = nivel - i;
                        a = i + (i - 1);
                        for (int i1 = 0; i1 < espacos; i1++)
                            final.Append(" ");

                        for (int i2 = 0; i2 < a; i2++)
                            final.Append("*");

                        Console.WriteLine(final.ToString());

                    }
                }
                else
                {
                    System.Console.Clear();
                    goto inicio;
                }

            }
            catch (Exception )
            {
                System.Console.Clear();
                Console.WriteLine("Digite um número INTEIRO, babaca:");
            }

            Console.WriteLine("" + "\n" + "Digite uma tecla para sair:");
            Console.ReadLine();
        }
    }
}

// using System;

// namespace Triangulo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//                 int j, i;
//             for (j = 0; j<=6; j==){
//             for (i=0; i< j; i++){ 
//         }
//     }
// }

