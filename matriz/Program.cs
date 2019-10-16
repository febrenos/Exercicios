// O QUE EU FIZ DIA: 23/09
// using System;
// namespace matriz
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] vetor = new int[6];
//             int impar = 0;
//             int par = 0;
//             for (int y = 0; y <= 5; y++)
//             {
//                 Console.Write("Digite o " + (y + 1) + "º número: ");
//                 vetor[y] = int.Parse(Console.ReadLine());
//                 if (vetor[y] % 2 != 0)
//                 {
//                     par += 1;
//                 }
//                 else
//                 {
//                     impar += 1;
//                 }
//             }
//             Console.WriteLine(impar + " Números ímpares");
//             Console.WriteLine(par + " Números pares");
//         }
//     }
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// como o professor fez:
using System;
namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int impar = 0;
            int par = 0;
            
            int[] vetor = new int [6];
            for (int cont = 0; cont < 6; cont++)
            {
                Console.Write($"Digite o {cont} número: ");
                vetor[cont] = int.Parse(Console.ReadLine());
            }

            foreach(int num in vetor){
                if(num % 2 == 0){
                    par++;
                } else {
                    impar++;
                }
            }
            Console.WriteLine($"Você tem {par} números pares e {impar} números ímpares");
        }
    }
}