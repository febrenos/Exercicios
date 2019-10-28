using System;
using System.Collections.Generic;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            List<int> _lista = new List<int>();
            while (i <= 2) {

            System.Console.WriteLine("Digite o Primeiro número:");
                Console.WriteLine("Digite seu " + (i + 1) + "º número");
                _lista.Add(int.Parse(Console.ReadLine()));

                i++;
            }
            // Aqui voce ordena e inverte a ordem
            _lista.Sort();
            _lista.Reverse();


            Console.WriteLine();
            Console.WriteLine("Os numeros digitados são:");

            foreach (int termo in _lista) {
                Console.WriteLine(termo);
            }
            Console.ReadKey();
        }
    }
}
// static void Main(string[] args)
//         {
//             int contador, contador2 = 0;
//             int[] vetor = new int[4];

//             for (contador = 0; contador < 4; contador++)
//             {
//                 Console.Write("Informe o numero: ");
//                 vetor[contador] = int.Parse(Console.ReadLine());
//             }            

//             Array.Sort(vetor);

//             for (contador = 3; contador >= 0; contador--) 
//             {
//                 Console.Write("\nO " + (contador + 1) + "º número é: ");                
//                 Console.Write(vetor[contador2]);
//                 contador2++;
//             }            
//             Console.ReadKey();
//         }
