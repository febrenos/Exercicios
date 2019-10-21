using System;
using Reciclagem;

namespace Reciclagem.Interface
{
    public class Papelao : IAzul
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo papel/papelao deve ser jogado no lixo azul.");
            return true;
        }

    }
}