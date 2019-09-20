// using System;

// namespace impar
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double valor1;
//             double valor1 = 1,3,5,7,9; 
//             if valor 1
//             double valores;
//             if (condição) {
            
//             } else {
            
//             }

//             Console.write("digite um número inteiro")
//             valor1 =double.Parse(console.ReadLine())
//             string Condicao;

//             Console.WriteLine("HEllo Word");
//             Console.WriteLine("Qual é o seu salário?");
//             Condicao = Console.ReadLine();
//             Console.WriteLine("Você receberá: 30% + " + Condicao );
//             Console.ReadKey();
//         }
//     }
// }
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

// using system;

// namespace par_ou_impar
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//         int num = 0;
//         Console.WriteLine("Digite um número inteiro:");
//             num = int.Parse(Console.ReadLine());
//         if (num % 2 == 0){
//             Console.WriteLine("O número é impar");
//         } else{
//             Console.WriteLine("O número é par");
//         }
//     }
// }
