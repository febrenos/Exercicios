
using System;
using System.Linq;
using ZooLogico.Interfaces;
using ZooLogico.Models.Animais;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            do{
                string forma="";
                Console.WriteLine("                                Animais");
                Console.WriteLine("1 Tubarão Martelo");
                Console.WriteLine("2 Tucano");
                Console.WriteLine("3 Arara");
                Console.WriteLine("4 Leão");
                Console.WriteLine("5 Orangotango");
                Console.WriteLine("6 Chimpanzé");
                Console.WriteLine("7 Pinguim");
                Console.WriteLine("8 Tartagura");
                Console.WriteLine("9 Golfinho");
                Console.WriteLine(".......................................................................................................................");
                Console.WriteLine("                                 JAULAS");

                Console.WriteLine("1 Pasto (gramíneas e terreno vasto, ligeiramente regular com algumas árvores);");
                Console.WriteLine("2 Gaiola (muitas árvores altas);");
                Console.WriteLine("3 Casa em árvore (florestas...);");
                Console.WriteLine("4 Caverna de pedra (cercada por capim alto, terra, algumas árvores e rochas num terro irregular);");
                Console.WriteLine("5 Piscina Gelada (água salgada e cercada por gelo);");
                Console.WriteLine("6 Piscina (água doce e com bastante mato, árvores e terra ao redor);");
                Console.WriteLine("7 Aquário (é com água salgada e não possui muita superfície terrestre para os animais).");
                System.Console.WriteLine("................................................................................................................");
                Console.WriteLine("");
                string forma="";

                Console.WriteLine("Digite o NÚMERO do animal: ");
                switch(forma){
                    case "1":
                        Console.Write("1 Tubarão Martelo  ");
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.Write("2 Tucano");
                        break;
                    case "3":
                        Console.Write("3 Arara");
                        break;
                    case "4":
                        Console.Write("4 Leão");
                        break;
                    case "5":
                        Console.Write("5 Orangotango");
                        break;
                    case "6":
                        Console.Write("6 Chimpanzé");
                        break;
                    case "7":
                        Console.Write("7 Pinguim");
                        break;
                    case "8":
                        Console.Write("8 Tartagura");
                        break;
                    case "9":
                        Console.Write("9 Golfinho");
                        break;
                }
                Console.WriteLine();
            }while(forma != "fim");

                Console.WriteLine("Digite o NÚMERO da Jaula do animal: ");
            if (1) {
                Console.WriteLine("1 Tubarão Martelo");
            } else {
                Console.WriteLine("");
            }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
        }   
    }
}
