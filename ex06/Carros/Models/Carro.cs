namespace Models
{
    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public Carro(string marca, string modelo, int ano, int numeroDePortas) 
            : base(marca, modelo, ano)
        {
            NumeroDePortas = numeroDePortas;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Número de Portas: {NumeroDePortas}");
        }
    }
}
