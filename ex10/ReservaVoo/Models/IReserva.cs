namespace Models
{
    public interface IReserva
    {
        void Reservar();
        void Cancelar();
        string VerificarStatus();
    }
}
