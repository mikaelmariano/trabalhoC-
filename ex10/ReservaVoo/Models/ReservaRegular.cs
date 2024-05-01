namespace Models
{
    public class ReservaRegular : IReserva
    {
        private string Voo { get; set; }
        private string Passageiro { get; set; }
        private string Status { get; set; }

        public ReservaRegular(string voo, string passageiro)
        {
            Voo = voo;
            Passageiro = passageiro;
            Status = "Pendente";
        }

        public void Reservar()
        {
            Status = "Reservado";
            Console.WriteLine($"Reserva regular para o voo {Voo} foi feita para o passageiro {Passageiro}.");
        }

        public void Cancelar()
        {
            Status = "Cancelado";
            Console.WriteLine($"Reserva regular para o voo {Voo} foi cancelada.");
        }

        public string VerificarStatus()
        {
            return $"Status da reserva: {Status}";
        }
    }
}
