namespace ContaBancaria
{
    public class Conta
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; private set; }

        public Conta(int numero, string titular)
        {
            NumeroConta = numero;
            TitularConta = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            SaldoConta = saldo;
        }

        public void Deposito(double quantia){
            SaldoConta += quantia;
        }

        public void Saque(double quantia){
            SaldoConta -= quantia;
            SaldoConta -= 5.00;
        }
        
        public override string ToString()
        {
            return "Conta " + NumeroConta + ", " + "Titular: " + TitularConta + ", " + "Saldo: R$ " + SaldoConta.ToString("F2");
        }
    }
}