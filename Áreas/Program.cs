using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula Area");
           Console.WriteLine("1 - quadrado"); 
           Console.WriteLine("2 - triangulo");
           Console.WriteLine("3 - circulo"); 
           Console.WriteLine("4 - trapezio");
           Console.WriteLine("5 - losango");
           Console.WriteLine("6 - retangulo");
           Console.Write("escolha uma opção: "); 
           string Oper;
           Opcao = Console.ReadLine();


            switch(apcao){
                case "1":
                Console.WritwLine("Area do quadrado");
                Console.write("Digite a base: ")
                double basetri = double.Parse(Console.ReadLine());
                Console.Write("Digite a Altura:");
                double altTri = double.Parse(Console.ReadLine());
                double areaTri = (basetri * altTRi) / 2;
                Console.WriteLine("A area do triangulo é: " + areaTri);
                break;
            } 

            case "2"
                Console.WriteLine("area do Quadrado");
                Console.Write("Qual o lado do quadrado? ");
                double ladoQuad = double.Parse(Console.ReadLine());
                double ladoQuad = ladoQuad * ladoQuad;
                Console.WriteLine("A área do quadrado é: " + areaQuad);
                break;
            }


        }
    }
}
