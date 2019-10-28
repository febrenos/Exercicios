using System;

namespace Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         ==========");
            Console.WriteLine("         =   IMC  =");
            Console.WriteLine("         ==========");
            Console.WriteLine("     IMC = peso / altura2");
            Console.WriteLine("Peso é dado em Kg   Altura é dada em metros");

                Console.WriteLine();
                Console.WriteLine("Informe seu peso: ");
                double P = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe sua altura: ");
                double A = Convert.ToDouble(Console.ReadLine());
                double Valor = P/(A * A);
                Console.WriteLine($"imc = {P} / {A} . {A} = {Valor}");
                Console.ReadKey();
            

            if(Valor <= 20){ 
                Console.WriteLine("Você possue um baixo peso.");
            } 
            if((Valor > 20 )&&(Valor <= 25)){
                Console.WriteLine("Você possue um peso normal.");
            }
            if((Valor > 25 )&&(Valor <= 30)){
                Console.WriteLine("Você possue um excesso de peso.");
            }
            if((Valor > 30 )&&(Valor <= 35)){
                Console.WriteLine("Você possue um baixo peso.");
            }
            if(Valor < 35 ){
                Console.WriteLine("Sua massa é maior que a de um planeta.");
                Console.WriteLine("Classificação = Gordo morfético");
            }
        }
    }
}
