namespace Bank
{
    public class Conta
    {
        private string Nome { get; set; }
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }


        public Conta(string nome, TipoConta tipoConta, double saldo, double credito)
        {
            this.Nome = nome;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            System.Console.WriteLine($"Deposito realizado. Novo saldo R${this.Saldo}");
        }
        public void VerSaldo()
        {
            System.Console.WriteLine($"Seu saldo é R$ {this.Saldo}");
        }
        public bool Sacar(double valorSaque)
        {
            if(valorSaque <= (this.Saldo + this.Credito))
            {
                this.Saldo -= valorSaque;
                System.Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso.");
                return true;
            }
            System.Console.WriteLine("Saldo insuficiente..");
            return false;
        }

        public void Transferir(Conta contaDestino, double valorTransferencia)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
                System.Console.WriteLine("Transferencia realizada com sucesso.");
            }
        }

        public override string ToString()
        {
            string retorno = "Nome " + this.Nome + " | ";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Saldo " + this.Saldo + "| ";
            retorno += "Credito " + this.Credito;

            return retorno;
        }


    }
}