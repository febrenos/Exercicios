namespace ByteBank {
    public class ContaCorrente {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public double _Saldo {
        
            get { return _Saldo;}
        }
        public ContaCorrente (int Agencia, int Numero, string Titular) {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }
        public double Deposito (double valor) {
            this.Saldo += valor;
            return this.Saldo += valor;
        }
        public bool Saque (double valor) {
            if (this.Saldo >= this.Saldo) {
                this.Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }
        public bool transferencia (ContaCorrente contaDestino, double valor) {
            if (this.Saque (valor)) {
                contaDestino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}