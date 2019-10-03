using System;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBamk - Cadastro de Clientes");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Cpf: ");
            string Cpf = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Cliente cliente1 = new Cliente(Nome,Cpf,Email);

            bool trocouSenha = false;
            do{
                Console.Write("Senha:");
                string Senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(Senha);
                if (trocouSenha){
                    Console.WriteLine("Senha alterada com sucesso!");
                } else {
                    Console.WriteLine("Senha Inválida");
                }

            }while(!trocouSenha); // usa o "!" para que o lupe seje verdadeiro
        }
    }
}
