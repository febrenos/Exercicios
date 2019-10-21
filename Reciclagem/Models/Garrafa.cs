using System;
using Reciclagem;

namespace Reciclagem.Interface
{
    public class Garrafa : IVerde
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo vidro deve ser jogado no verde.");
            return true;
        }

    }
}