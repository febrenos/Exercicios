using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank2.Models
{

    public abstract class ContaEspecial : ContaBancaria
    {
            public double Limite;   // irá começar zerado pois limite é igual a zero
        public ContaEspecial(int Agencia, int NumeroConta, string Titular) : base(Agencia,NumeroConta,Titular)
        {
            Limite = 0.0;
        }

        public bool SetLimite(double Valor)
        {
            if(Valor >= 0)   // se não for ">= 0" ele vai para o "return false"
            {               //  e encerra a operação sendo ela inválida 
                Limite = Valor;
                return true;
            }
            return false;
        }

        public override bool Saque(double Valor) //essa parte serve para subscrever a classe "pai"
        {
            if(Valor >= 0)
            {
                if(Valor <= Saldo + Limite)
                {
                    Saldo -= Valor;
                    return true;
                }
            }
            return false;
        }
    }
}