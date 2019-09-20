// using System;

// namespace calculadora
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             double salario;
//             double reajuste; 

//             Console.WriteLine("Seu salário: ");
//             salario = Console.ReadLine();

//             if(salario < 500){
//                 salario=
//                 Console.Write();
//             }else {
//                 Console.WriteLine("sem salário extra.VAZA!");
//             }
//             }

//         }
//     }
// } 

using System;

namespace AulaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // double valor1;
            // double valor1 = 30.0/100.0
            // double valores;
            // valor1 = double.Parse("..")
            string Condicao;

            Console.WriteLine("HEllo Word");
            Console.WriteLine("Qual é o seu salário?");
            Condicao = Console.ReadLine();
            Console.WriteLine("Você receberá: 30% + " + Condicao );
            Console.ReadKey();
        }
    }
}