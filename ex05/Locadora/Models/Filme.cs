namespace Models
{
    public class Filme
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; } // Em minutos
        public bool Disponivel { get; private set; } // Indica se está disponível para locação

        public Filme(string titulo, string genero, int duracao)
        {
            Titulo = titulo;
            Genero = genero;
            Duracao = duracao;
            Disponivel = true;
        }
        public void RegistrarLocacao()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"O filme '{Titulo}' foi locado.");
            }
            else
            {
                Console.WriteLine($"O filme '{Titulo}' não está disponível para locação.");
            }
        }

        public void RegistrarDevolucao()
        {
            Disponivel = true;
            Console.WriteLine($"O filme '{Titulo}' foi devolvido.");
        }

        public bool EstaDisponivel()
        {
            return Disponivel;
        }
    }
}
