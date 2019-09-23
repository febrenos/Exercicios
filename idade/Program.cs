using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano   = 0;
            int idade = 0;
            do{
                Console.Write("Em que dia você nasceu?");
                ano = int.Parse(Console.ReadLine());
                if((ano > 2021) || (ano < 0)){
                    Console.WriteLine("data invalida");
                }
            } while((ano > 2021) || (ano < 0));

            idade = 2019 - ano;

            if(idade < 3) {
                Console.WriteLine("você é: recem Nascido");
            } else if((idade >= 3) && (idade <= 11)){
                Console.WriteLine("você é: Criança");
            } else if((idade >= 12) && (idade <= 19)){
                Console.WriteLine("você é: Adolescente");
            } else if((idade >= 20) && (idade <= 65)){
                Console.WriteLine("você é: Adulto");
            } else if(idade >= 65) {
                Console.WriteLine("você é: Veinho");
            } 


        }
    }
}
