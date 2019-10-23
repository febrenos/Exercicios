using System;
using Reciclagem;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class Papelao : IAzul
    {
        public bool AzulPapel()
        {
            throw new NotImplementedException();
        }

        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo papel/papelao deve ser jogado no lixo azul.");
            return true;
        }

    }
}