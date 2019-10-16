using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.InterFace;

namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    }

    enum InstrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum : int
    {
        HARMONIA,
        PERCURSSAO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
            sytring[] itensMenuPrincipa = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                " - 0 ",
                " - 1 "
            };

            int opcoesFormacaoSelecionad = 0;
            string menuBar = "=================================";

            do
            {
                bool formacaoEscolhida = false;

                do
                {
                    #region Area do menu
                    Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("   sejabem-vind@!         ");
                    Console.WriteLine("   escolha uma formacao:  ");
                    Console.ResetColor();
                    Console.WriteLine(menuBar);

                    for(int i = 0; i< opcaoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if(opcaoFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine();
                            Console.ResetColor(); 
                        }
                        else
                        {
                            Console.WriteLine(opcoesFormacao[i].Repleace(i.ToString(), titulo));
                        }
                    }

                    var key = Console.ReadKey(true).key;
                    switch(key)
                    {
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcaoFormacao.Count - 1 ? opcaoFormacaoSelecionada : -opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }
                    #endregion
                }while (formacaoEscolhida);
            }while (!querSair);
        }
    }
}
