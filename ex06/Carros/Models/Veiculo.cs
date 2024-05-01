namespace Models
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Veículo: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}
