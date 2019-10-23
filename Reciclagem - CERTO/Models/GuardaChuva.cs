using System;
using Reciclagem;
using Reciclagem.Interface;

namespace Reciclagem.Models
{
    public class GuardaChuva : ICinza
    {
        public bool CinzaIndefinido()
        {
            throw new NotImplementedException();
        }

        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo item com diversos materiais deve ser jogado no cinza.");
            return true;
        }

    }
}