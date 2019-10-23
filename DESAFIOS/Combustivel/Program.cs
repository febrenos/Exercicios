using System;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma="";
            do{

                Console.WriteLine("Calcular Combustível");
                Console.WriteLine("Criar um programa que efetue o cálculo da quantidade de litros de");
                Console.WriteLine("combustível gastos em uma viagem, sabendo-se que o carro faz 12 km com um");
                Console.WriteLine("litro. Deverão ser fornecidos o tempo gasto na viagem e a velocidade média.");
                Console.WriteLine("Utilizar as seguintes fórmulas:");
                Console.WriteLine("...................................................................................");
                Console.WriteLine("Distância = tempo x velocidade.Console.");
                Console.WriteLine("Litros usados = distância / 12.");



                switch(forma){
                    case "2":
                        Console.WriteLine(" Digite a Distância: ");
                        double D = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Digite o Tempo: ");
                        double T = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Digite a Velocidade: ");
                        double V = double.Parse(Console.ReadLine());
                        double areaQuad = a * b;
                        Console.WriteLine("A área do Retãngulo é " + areaQuad);
                        break;
                Console.WriteLine();
            }while(forma != "fim");
        }
    }
}