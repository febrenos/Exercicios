using System;
using Reciclagem.Models;
using System.Collections.Generic;
using Reciclagem.Interface;

namespace Reciclagem
{

    enum CoresEnum : int
    {
        Amarelo,
        Azul,
        Verde,
        Vermelho,
    };

    enum LixosEnum : int
    {
        Garrafa,
        GarrafaPet,
        GuardaChuva,
        Latinha,
        Papelao,
        PoteManteiga

    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = true;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));
            string menuBar = "===========================";

            do 
            {
                bool formacaoEscolhida = false;
                do
                {
                    #region Area do menu
                    Console.Clear();
                    Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("     diga o que é seu lixo:  ");
                    Console.WriteLine(" Papel    =   Azul     ");
                    Console.WriteLine(" Plástico =   Vermelho");
                    Console.WriteLine(" Metal = Amarelo");
                    Console.WriteLine(" Africano = lixo Preto");
                    Console.WriteLine(" organico = lixo Preto");
                    Console.WriteLine("Guarda chuva = Cinza");
                    Console.WriteLine("judeu = Cinza");
                    Console.WriteLine(" ");
                    Console.WriteLine("judeu = Cinza");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine(menuBar);
                }while(!formacaoEscolhida);
            }while(!querSair);
        #endregion   
        }
    }
}