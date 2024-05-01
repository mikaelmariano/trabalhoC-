namespace Models
{
    public class ReservaGrupo : IReserva
    {
        private string Voo { get; set; }
        private List<string> Passageiros { get; set; }
        private string Status { get; set; }

        public ReservaGrupo(string voo, List<string> passageiros)
        {
            Voo = voo;
            Passageiros = passageiros;
            Status = "Pendente";
        }

        public void Reservar()
        {
            Status = "Reservado";
            Console.WriteLine($"Reserva para voo {Voo} com {Passageiros.Count} passageiros foi feita.");
        }

        public void Cancelar()
        {
            Status = "Cancelado";
            Console.WriteLine($"Reserva para voo {Voo} foi cancelada.");
        }

        public string VerificarStatus()
        {
            return $"Status da reserva: {Status}";
        }
    }
}
