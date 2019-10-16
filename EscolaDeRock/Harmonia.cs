using System;

namespace EscolaDeRock.Interfaces
{
    public interface IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando Acordes");
            return true;
        }
    }
}
