using System;
namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Console.WriteLine("Calcula Area");
            Console.WriteLine("1 - Triangulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Losango");
            Console.WriteLine("4 - Trapezio");
            Console.WriteLine("5 - Retangulo");
            Console.WriteLine("6 - Circulo");
            Console.WriteLine("7 - Bhaskara");
            Console.WriteLine("Digite o número desejado:");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Área do Triangulo");
                    Console.WriteLine("Fómula: base * altura / 2");
                    Console.Write("Digite o valor da Base: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da altura:");
                    double altTri = double.Parse(Console.ReadLine());
                    double areaTri = (baseTri * altTri) / 2;
                    Console.WriteLine("A área do triangulo é: " + areaTri);
                    break;
                case "2":
                    Console.WriteLine("Área do Quadrado");
                    Console.Write("Digite o valor da base:");
                    double baseQuad = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da altura:");
                    double altQuad = double.Parse(Console.ReadLine());
                    double areaQuad = (altQuad * baseQuad);
                    Console.WriteLine("A área do quadrado é: " + areaQuad);
                    break;
                case "3":
                    Console.WriteLine("Área do Loosango");
                    Console.Write("Digite o valor da diagonal maior:");
                    double diagmaLosang = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da diagonal menor:");
                    double diagmeLosang = double.Parse(Console.ReadLine());
                    double areaLosang = (diagmaLosang * diagmeLosang / 2);
                    Console.WriteLine("A área do quadrado é: " + areaQuad);
                    break;
                case "4":
                    Console.WriteLine("Área do Trapézio");
                    Console.Write("Digite o valor da base maior:");
                    double basemaTrap = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da base menor:");
                    double basemeTrap = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da altura:");
                    double altTrap = double.Parse(Console.ReadLine());
                    double areaTrap = (basemaTrap + basemeTrap * altTrap / 2);
                    Console.WriteLine("A área do quadrado é: " + areaQuad);
                    break;
                case "5":
                    Console.WriteLine("Área do Retangulo");
                    Console.Write("Digite o valor da base:");
                    double baseRet = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da altura:");
                    double altRet = double.Parse(Console.ReadLine());
                    double areaRet = (baseRet * altRet);
                    Console.WriteLine("A área do Retangulo é: " + areaQuad);
                    break;
                case "6":
                    Console.WriteLine("Área do Circulo");
                    Console.Write("Digite o valor de Pi:");
                    double piCirc = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor do raio:");
                    double raioCirc = double.Parse(Console.ReadLine());
                    double raioCirc = double.Parse(Console.ReadLine());
                    double areaQuad = (piCirc * raioCirc );
                    Console.WriteLine("A área do Circulo é: " + areaQuad);
                break;
                case "7":
                    Console.WriteLine("Bhaskara");
                    Console.Write("Digite o valor da base:");
                    double baseQuad = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da altura:");
                    double altQuad = double.Parse(Console.ReadLine());
                    double areaQuad = (altQuad * baseQuad);
                    Console.WriteLine("O valor do Bhaskara é: " + areaQuad);
                break;
                }
            }
        }
    }
}