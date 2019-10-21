using System;
using Reciclagem;

namespace Reciclagem.Interface
{
    public class Papelao : IAzul
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo plástico deve ser jogado no lixo vermelho.");
            return true;
        }

    }
}