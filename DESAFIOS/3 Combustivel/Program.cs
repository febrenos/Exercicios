using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma="";
                Console.WriteLine("Calcular Combustível");
                Console.WriteLine("Criar um programa que efetue o cálculo da quantidade de litros de");
                Console.WriteLine("combustível gastos em uma viagem, sabendo-se que o carro faz 12 km com um");
                Console.WriteLine("litro. Deverão ser fornecidos o tempo gasto na viagem e a velocidade média.");
                Console.WriteLine("Utilizar as seguintes fórmulas:");
                Console.WriteLine("...........................................................................");
                Console.WriteLine("1---> Calcular a {Distância} = tempo x velocidade.");
                Console.WriteLine("2---> Calcular a {Litros usados} = distância / 12.");
                Console.WriteLine("Digite 1 ou 2:");
                forma = Console.ReadLine();

            switch(forma){
                case "1":
                    Console.WriteLine(" Digite a velocidade: ");
                    double V = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Digite o Tempo: ");
                    double T = double.Parse(Console.ReadLine());
                    double Distancia = V * T;
                    Console.WriteLine("A Distância é: " + Distancia);
                break;
                case "2":
                    Console.WriteLine(" Digite a distância: ");
                    double D = double.Parse(Console.ReadLine());
                    double LitrosUsados = D / 12;
                    Console.WriteLine("A quantidade de Litros usados são: " + LitrosUsados);
                break;
            }
        }
    }
}