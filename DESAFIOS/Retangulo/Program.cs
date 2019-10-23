using System;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma="";
            do{

                Console.WriteLine("Calcular dimençoes");
                Console.WriteLine(" do Retângulo");

                switch(forma){
                    case "2":
                        Console.WriteLine(" Digite a base: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Digite a altura:");
                        double a = double.Parse(Console.ReadLine());
                        double areaQuad = a * b;
                        double periQuad = b + a + b + a;
                        double diagQuad = a * a + b * b;
                        Console.WriteLine("A área do Retãngulo é " + areaQuad);
                        Console.WriteLine("O perímetro do Retãngulo é " + periQuad);
                        Console.WriteLine("A diagonal do Retãngulo é " + diagQuad);
                        break;
                Console.WriteLine();
            }while(forma != "fim");
        }
    }
}
