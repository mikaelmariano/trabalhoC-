namespace Models
{
    public class ContaEmpresarial : Conta
    {
        public double SaldoMinimo { get; set; }

        public ContaEmpresarial(string numeroConta, string titular, double saldoInicial, double saldoMinimo)
            : base(numeroConta, titular, saldoInicial)
        {
            SaldoMinimo = saldoMinimo;
        }

        public override void Sacar(double valor)
        {
            if (Saldo - valor < SaldoMinimo)
            {
                Console.WriteLine("Saldo insuficiente para saque mantendo o saldo mínimo exigido.");
            }
            else
            {
                base.Sacar(valor);
            }
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Conta Empresarial:\nNúmero: {NumeroConta}\nTitular: {Titular}\nSaldo: {Saldo:C}\nSaldo Mínimo: {SaldoMinimo:C}");
        }
    }
}
