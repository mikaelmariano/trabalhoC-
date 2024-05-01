namespace Models
{
    public abstract class Conta
    {
        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta(string numeroConta, string titular, double saldoInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado na conta {NumeroConta}. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public virtual void Sacar(double valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado na conta {NumeroConta}. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
            }
        }

        public abstract void ExibirInfo();
    }
}
