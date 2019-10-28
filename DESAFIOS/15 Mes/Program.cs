using System;

namespace Peso {
    class Program {
        static void Main (string[] args) {
            int Opcao;
            Console.WriteLine ("  Meses ");
            Console.WriteLine ("1   janeiro");
            Console.WriteLine ("2   fevereiro");
            Console.WriteLine ("3   março");
            Console.WriteLine ("4   abril");
            Console.WriteLine ("5   maio");
            Console.WriteLine ("6   junho");
            Console.WriteLine ("7   julho");
            Console.WriteLine ("8   agosto");
            Console.WriteLine ("9   setembro");
            Console.WriteLine ("10  outubro");
            Console.WriteLine ("11  novembro");
            Console.WriteLine ("12  dezembro ");
            System.Console.WriteLine("");
            Console.WriteLine ("Digite um numero de 1 á 12:");
            
            Opcao = int.Parse (Console.ReadLine ());
            switch (Opcao) {
                case 1:
                Console.WriteLine ("1 corresponde a janeiro");
                break;

                case 2:
                Console.WriteLine ("2 corresponde a fevereiro");
                break;

                case 3:
                Console.WriteLine ("3 corresponde a março");
                break;

                case 4:
                Console.WriteLine ("4 corresponde a abril");
                break;

                case 5:
                Console.WriteLine ("5 corresponde a maio");
                break;

                case 6:
                Console.WriteLine ("6 corresponde a junho");
                break;

                case 7:
                Console.WriteLine ("7 corresponde a julho");
                break;

                case 8:
                Console.WriteLine ("8 corresponde a agosto");
                break;

                case 9:
                Console.WriteLine ("9 corresponde a setembro ");
                break;

                case 10:
                Console.WriteLine ("10 corresponde a outubro");
                break;

                case 11:
                Console.WriteLine ("11 corresponde a novembro");
                break;

                case 12:
                Console.WriteLine ("12 corresponde a dezembro");
                break;

                default:
                break;
            }

        }
    }
}
