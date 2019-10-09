
using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("preencha as perguntas ");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("data de nascimento: ");
            int DataNascimento = int.Parse(Console.ReadLine());
            Console.Write("curso: ");
            string Curso = Console.ReadLine();
            Console.Write("Qual o número da sala: ");
            int NumeroSala = int.Parse(Console.ReadLine());
        }
    }
}