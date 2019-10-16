using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
        public class violao : instrumentoMusical, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acodes de Violão.");
            return true;
        }
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes do violao.");
            return true;
        }
        public bool TocarSolo()
        {
            Console.WriteLine("Tocando o solo do violao.");
            return true;
        }
    }
}