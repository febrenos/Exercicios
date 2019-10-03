using System;

namespace bytebank
{
    public class Cliente
    {
        public string Nome;
        public string Cpf;
        public string Email;
        public string Senha;

        public Cliente(string Nome, string Cpf, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        public bool TrocaSenha(string Senha)
        {
            if ((Senha.Length > 6) && (Senha.Length < 16))
            { //usa-se lenght: por conta que é uma string
                this.Senha = Senha;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}