namespace Models
{
    public class ReservaUpgrade : IReserva
    {
        private string Voo { get; set; }
        private string Passageiro { get; set; }
        private string Classe { get; set; }
        private string Status { get; set; }

        public ReservaUpgrade(string voo, string passageiro, string classe)
        {
            Voo = voo;
            Passageiro = passageiro;
            Classe = classe;
            Status = "Pendente";
        }

        public void Reservar()
        {
            Status = "Reservado";
            Console.WriteLine($"Reserva para voo {Voo} com upgrade para {Classe} foi feita para {Passageiro}.");
        }

        public void Cancelar()
        {
            Status = "Cancelado";
            Console.WriteLine($"Reserva com upgrade para voo {Voo} foi cancelada.");
        }

        public string VerificarStatus()
        {
            return $"Status da reserva: {Status}";
        }
    }
}
