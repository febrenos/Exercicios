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