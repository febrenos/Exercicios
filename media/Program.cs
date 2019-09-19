// using System;

// namespace calculadora
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double  Nota1, Nota2, Nota3, Nota4, media;

//             Console.Write("Digite o 1º número:");
//             Nota1 = double.Parse(Console.ReadLine());
//             Console.Write("Digite o 2º número:");
//             Nota2 = double.Parse(Console.ReadLine());
//             Console.Write("Digite o 3º número:");
//             Nota3 = double.Parse(Console.ReadLine());
//             Console.Write("Digite o 4º número:");
//             Nota4 = double.Parse(Console.ReadLine());

//             media = (Nota1 + Nota2 + Nota3 + Nota4) /4;

//             Console.WriteLine("sua média é: " + media);
//         }
//     }
// } 

using System;

namespace calculadora
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.Write("Digite o 1º número:");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número:");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º número:");
            nota3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 4º número:");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua média é:" + media);

            if(media>=7){
                Console.Write("parabens você passou");
            }

            else if(media<=7){
                Console.Write("parabens foi burro e repetiu");
            }




            

        }
    }
}






// using System;

// namespace calculadora
// {
    
//     class Program
//     {
        
//         static void Main(string[] args)
//         {
            // double nota1, nota2, nota3, nota4, media;

            // Console.WriteLine("Digite o 1º número:");
            // nota1 = double.Parse(Console.ReadLine());
            // Console.WriteLine("Digite o 2º número:");
            // nota2 = double.Parse(Console.ReadLine());
            // Console.writeLine("Qual o operador desejado?");
            // oper = Console.Readline();


            // media = nota1 + nota2 + nota3 + nota4 /4;

            // Console.writeLine("sua média é" + media);

// switch(oper){
            //     case "+":
            //         Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //         break;

            //     case "-":
            //         Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //         break;

            //     case "*":
            //         Console.WriteLine($"{num1} * {num2} * = {num1 * num2}");
            //         break;

            //     case "/":
            //         Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //         break;

            //     case "%":
            //         Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            //         break;

            //     default:
            //         console.Writeline("operação Inválida!");
            //         break;




                // if(oper=="+"){
                //     Console.Write($"{num1} + {num2} = {num1 + num2}");
                // }

                // else if(oper "-"){
                //     Console.Write($"{num1} - {num2 } = {num1 - num2}");
                // }
                // else if(oper "*"){
                //     Console.Write($"{num1} * {num2 } * = {num1 * num2}");
                // }
                // else if(oper "/"){
                //     Console.Write($"{num1} / {num2 } = {num1 / num2}");
                // }
                // else if(oper "%"){
                //     Console.Write($"{num1} % {num2 } = {num1 % num2}");
                // } else {
                //     console.Write("operação Inválida!");
                // }