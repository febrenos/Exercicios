using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ltriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variáveis
            int A;
            int B;
            int C;

            // Nome do programa
            Console.WriteLine("=============================");
            Console.WriteLine("=  SABER SE É UM TRIÂNGULO  =");
            Console.WriteLine("=============================");
            Console.WriteLine("Para ser triangulo os dois lados"); 
            Console.WriteLine("precisarao ser maiores que um.");
            Console.WriteLine();
            Console.WriteLine("| b - c | < a < b + c ");
            Console.WriteLine("| a - c | < b < a + c ");
            Console.WriteLine("| a - b | < c < a + b ");
            Console.WriteLine();
            //Pedindo as entradas
            Console.WriteLine(" ");
            Console.Write("Informe o lado A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Informe o lado B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Informe o lado C: ");
            C = Convert.ToInt32(Console.ReadLine());

            //Verificando triangulo 
            if ((A<B+C) && (B<A+C) && (C<A+B)){
                Console.WriteLine(" ");
                Console.Write("Formam triângulo!");
				
				if ((A==B) && (B==C)){  // Se a soma desses lados forem iguais
					Console.WriteLine(" ");
					Console.Write("Triângulo Equilátero");
				
				}else if ((A==B) || (B==C) || (A==C)){ // Se a soma desses lados forem iguais
					Console.WriteLine(" ");
					Console.Write("Triângulo Isósceles");
				}else{
					Console.WriteLine(" ");
					Console.Write("Triângulo Escaleno"); // Se nao for nenhum dos dois será Escaleno
				}
				
            }else{
                Console.WriteLine(" ");
                Console.Write("Os valores não formam um triângulo!");
            }
        }
    }
}
