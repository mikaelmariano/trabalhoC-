namespace Models
{
    public interface IMetodoPagamento
    {
        void RealizarPagamento(double valor);
        string VerificarStatus();
    }
}
