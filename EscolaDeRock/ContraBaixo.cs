using System;
using EscolaDeRock;

namespace EscolaDeRock.models
{
    public class Contrabaixo : InstrumentoMusical, Ioercussao, IHarmonia
    {
        public bool ManterRitimo()
        {
            Console.WriteLine("Manter ritimo Contra baixo");
            return true;
        }
        public bool TocarAcorde()
        {
            Console.WriteLine("tocando Acordes do Contra Baixo");
            return true;
        }
    }
}