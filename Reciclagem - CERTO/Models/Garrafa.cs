using System;
using Reciclagem;
using Reciclagem.Interface;

namespace Models.Interface
{
    public class Garrafa : IVerde
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo vidro deve ser jogado no verde.");
            return true;
        }

        public bool VerdeVidro()
        {
            throw new NotImplementedException();
        }
    }
}