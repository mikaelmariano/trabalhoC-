namespace Models
{
    public class TransferenciaBancaria : IMetodoPagamento
    {
        private string BancoOrigem { get; set; }
        private string ContaOrigem { get; set; }
        private string BancoDestino { get; set; }
        private string ContaDestino { get; set; }
        private string Status { get; set; }

        public TransferenciaBancaria(string bancoOrigem, string contaOrigem, string bancoDestino, string contaDestino)
        {
            BancoOrigem = bancoOrigem;
            ContaOrigem = contaOrigem;
            BancoDestino = bancoDestino;
            ContaDestino = contaDestino;
            Status = "Pendente";
        }

        public void RealizarPagamento(double valor)
        {
            Status = "Pago";
            Console.WriteLine($"Pagamento de {valor:C} realizado por transferência bancária de {BancoOrigem}-{ContaOrigem} para {BancoDestino}-{ContaDestino}.");
        }

        public string VerificarStatus()
        {
            return $"Status do pagamento: {Status}";
        }
    }
}
