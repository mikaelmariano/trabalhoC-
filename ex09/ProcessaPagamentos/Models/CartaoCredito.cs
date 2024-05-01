namespace Models
{
    public class CartaoCredito : IMetodoPagamento
    {
        private string NumeroCartao { get; set; }
        private string NomeTitular { get; set; }
        private string Validade { get; set; }
        private string Status { get; set; }

        public CartaoCredito(string numeroCartao, string nomeTitular, string validade)
        {
            NumeroCartao = numeroCartao;
            NomeTitular = nomeTitular;
            Validade = validade;
            Status = "Pendente";
        }

        public void RealizarPagamento(double valor)
        {
            Status = "Pago";
            Console.WriteLine($"Pagamento de {valor:C} realizado com cartão de crédito ({NumeroCartao}).");
        }

        public string VerificarStatus()
        {
            return $"Status do pagamento: {Status}";
        }
    }
}
