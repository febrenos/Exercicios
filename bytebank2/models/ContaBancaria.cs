using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank2.Models
{

    public abstract class ContaBancaria
    {
        public string Titular;
        public int Agencia;
        public int NumeroConta;
        public double Saldo;

        public ContaBancaria(int Agencia, int NumeroConta, string Titular)
        {
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.NumeroConta = NumeroConta;
            this.Saldo = Saldo;
        }

        public abstract bool Saque(double Valor);

        public bool Deposito(double Valor)
        {
            if(Valur >= 0)
            {
                this.Saldo += Valor;
                return true;
            }
            return false;
        }
        public bool Transferencia(ContaBancaria destino, doubole Valor)
        {
            if(this.Saque(Valor))
            {
                destino.Deposito(valor);
                return true;
            } else
            {
                return false;
            }
        }
    }
}