using System;

namespace cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente Cliente1 = new Cliente("jose","55 55 5555-5555","ze@email.com");

            Console.WriteLine("nome: " + Cliente1.Nome);
            Console.WriteLine("Telefone: " + Cliente1.Telefone);
            Console.WriteLine("Email: " + Cliente1.Email);
        }
    }
}