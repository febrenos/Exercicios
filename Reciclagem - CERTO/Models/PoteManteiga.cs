using System;
using Reciclagem;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class PoteManteiga : IAzul
    {
        public bool AzulPapel()
        {
            throw new NotImplementedException();
        }

        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo plástico deve ser jogado no lixo vermelho.");
            return true;
        }

    }
}