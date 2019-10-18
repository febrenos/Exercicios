using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank2.Models
{

    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int Agencia, int NumeroConta, string Titular) : base(Agencia,NumeroConta,Titular)
        {

        }
        public override bool Saque(double Valor) //essa parte serve para subscrever a classe "pai"
        {
            if(Valor >= 0)
            {
                if(Valor <= this.Saldo)
                {
                    this.Saldo -= Valor;
                    return true;
                } 
                else 
                {
                    return false;
                }
            }
            return false;
        }
    }
}