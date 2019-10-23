using System;
using Reciclagem;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class GarrafaPet : IVermelho
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo Plástico deve ser jogado no Vermelho.");
            return true;
        }

        public bool VermelhoPlastico()
        {
            throw new NotImplementedException();
        }
    }
}