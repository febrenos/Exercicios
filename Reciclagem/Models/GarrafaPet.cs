using System;
using Reciclagem;

namespace Reciclagem.Interface
{
    public class GarrafaPet : IVermelho
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo Plástico deve ser jogado no Vermelho.");
            return true;
        }

    }
}