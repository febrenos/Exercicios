using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical, IPercurssao, IHarmonia
    { 
        public bool ManterRitimo()
        {
            Console.WriteLine("manter o ritimo do Baixo");
            return true;
        }

        public bool TocarAcorde()
        {
            Console.WriteLine("tocando Acordes do Baixo");
            return true;
        }
    }
}