namespace Models
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string numeroConta, string titular, double saldoInicial)
            : base(numeroConta, titular, saldoInicial)
        {
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Conta Corrente:\nNúmero: {NumeroConta}\nTitular: {Titular}\nSaldo: {Saldo:C}");
        }
    }
}
