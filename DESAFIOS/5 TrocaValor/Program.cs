using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma="";
            do{
                Console.WriteLine(" Digite {.}");
                forma = Console.ReadLine();

                    Console.WriteLine(" Digite o valor de A: ");
                        int A= int.Parse(Console.ReadLine());
                        Console.WriteLine(" Digite o valor de B:");
                        int B = int.Parse(Console.ReadLine());
                        int ValorB =  A;
                        int ValorA = B ;
                    if(A == B){
                        System.Console.WriteLine("Os valores são iguais ou seja,");
                        System.Console.WriteLine("alteração nãoa afetara em nada");
                    }else if(A != B){ 
                        Console.WriteLine($" valor de A é: {ValorB}");
                        Console.WriteLine($" valor de B é: {ValorA}");
                        }
            }while(forma != "fim");
        }
    }
}

