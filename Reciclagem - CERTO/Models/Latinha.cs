using System;
using Reciclagem;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class Latinha : IAmarelo
    {
        public bool AmareloMetal()
        {
            throw new NotImplementedException();
        }

        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo metal deve ser jogado no lixo amarelo.");
            return true;
        }

    }
}