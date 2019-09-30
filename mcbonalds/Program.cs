using System;

namespace mcbonalds
{
    public class Cliente
    {
        //prpriedades
        public string nome;         //nome do cliente
        public string Endereço;     //Endereço do cliente
        public string Telefone;     //Telefone do cliente
        public string Senha;        //Senha de acesso do cliente ao sistema
        public string Email;        //Email do cliente e nome de usuário do sistema
        public DateTime DataNascimento;     //Data de nascimento do cliente

        //construtores
        public Clientes(string nome, string Telefone, string Email){
            this.nome = nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}