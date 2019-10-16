using System;
using EscolaDeRock;

namespace EscolaDeRock.models
{
    public class Guitarra : intrumentoMusical, Imelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes da guitarra.");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo da Guitarra.");
            return true;
        }
    }
}