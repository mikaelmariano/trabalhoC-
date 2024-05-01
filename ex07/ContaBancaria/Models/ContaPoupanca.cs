namespace Models
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJurosAnual { get; set; }

        public ContaPoupanca(string numeroConta, string titular, double saldoInicial, double taxaJurosAnual)
            : base(numeroConta, titular, saldoInicial)
        {
            TaxaJurosAnual = taxaJurosAnual;
        }

        public void CalcularJuros()
        {
            double juros = Saldo * TaxaJurosAnual / 100;
            Depositar(juros);
            Console.WriteLine($"Juros de {juros:C} aplicados na conta {NumeroConta}.");
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Conta Poupança:\nNúmero: {NumeroConta}\nTitular: {Titular}\nSaldo: {Saldo:C}\nTaxa de Juros Anual: {TaxaJurosAnual}%");
        }
    }
}
