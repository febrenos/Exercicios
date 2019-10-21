using System;
using Reciclagem;

namespace Reciclagem.Interface
{
    public class GuardaChuva : ICinza
    {
        public bool LixoNoLixo()
        {
            System.Console.WriteLine("Todo item com diversos materiais deve ser jogado no cinza.");
            return true;
        }

    }
}