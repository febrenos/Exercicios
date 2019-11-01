using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {            
            System.Console.WriteLine("Matriz 3x3");
            int[,] num = new int[3,3];
            for (int i = 0; i <= 10; i++){
                Console.WriteLine($"{i}");
                // int Valor = 0.0 + 0.1 + 0.2 + 0.3 + 1.0 + 1.1 + 1.2 + 1.3 + 2.0 + 2.1 + 2.2 + 2.3 + 3.0 + 3.1 + 3.2 + 3.3;
            System.Console.WriteLine($"{0.0} + {0.1} + {0.2} + {0.3} + {1.0} + {1.1} + {1.2} + {1.3} + {2.0} + {2.1} + {2.2} + {2.3} + {3.0} + {3.1} + {3.2} + {3.3}");
            System.Console.WriteLine("Somando tudo:");
            Console.WriteLine("${.}");
            }
        }
    }
}
