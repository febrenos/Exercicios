using System;

namespace bytebank
{
    public class Cliente
    {
        public string _Nome{get;set;}
        public string _Cpf{get;set;}
        public string _Email{get;set;}
        private string _Senha{get;set;}
        
            get { return _Senha; };
        
        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = Value; }
        }
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = Value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = Value; }
        }
        

        public Cliente(string Nome, string Cpf, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        public bool TrocaSenha(string Senha)
        {
            if ((Senha.Length > 6) && (Senha.Length < 16)){     //usa-se lenght: por conta que é uma string
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

using System;

namespace Byte_Bank
{
    public class Cliente
    {
        private string _Cpf {get;set;}
        private string _Nome {get;set;}
        private string _Email {get;set;}
        private string _Senha;

        public string Senha 
        {
            get {return _Senha; }
        }

        public string Cpf
        {
            get {return _Cpf; }
        }

        public string Email 
        {
            get {return _Email; }
        }

        public string Nome 
        {
            get {return _Nome; }
        }
        
        public Cliente (string Cpf, string Nome, string Email)
        {
            this._Nome = Nome;
            this._Cpf = Cpf;
            this._Email = Email;
        }

        public bool TrocaSenha (string senha){
            if ((senha.Length > 6) && (senha.Length < 16)){
                this._Senha = senha;
                return (true);
            }else {
                return (false);
            }
        }
    }
}