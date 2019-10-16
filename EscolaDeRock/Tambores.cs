using System;
using System;

namespace EscolaDeRock.models
{
    public class Tambores : InstrumentoMusical, IPercurssao
    {
        public bool ManterRitimo ()
        {
            Console.WriteLine("mAntendo o titimo dos tambores.");
            return true;
        }
    }

}