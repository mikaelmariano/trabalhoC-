namespace Models
{
    public class BoletoBancario : IMetodoPagamento
    {
        private string NumeroBoleto { get; set; }
        private string Status { get; set; }

        public BoletoBancario(string numeroBoleto)
        {
            NumeroBoleto = numeroBoleto;
            Status = "Pendente";
        }

        public void RealizarPagamento(double valor)
        {
            Status = "Pago";
            Console.WriteLine($"Pagamento de {valor:C} realizado com boleto bancário ({NumeroBoleto}).");
        }

        public string VerificarStatus()
        {
            return $"Status do pagamento: {Status}";
        }
    }
}
