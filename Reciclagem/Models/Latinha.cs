using System;
using Reciclagem;

namespace Reciclagem.Interface
{
    public class Latinha : IAmarelo
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo metal deve ser jogado no lixo amarelo.");
            return true;
        }

    }
}