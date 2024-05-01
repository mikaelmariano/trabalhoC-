namespace Models
{
    public class Bicicleta : Veiculo
    {
        public int NumeroDeMarchas { get; set; }

        public Bicicleta(string marca, string modelo, int ano, int numeroDeMarchas) 
            : base(marca, modelo, ano)
        {
            NumeroDeMarchas = numeroDeMarchas;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Número de Marchas: {NumeroDeMarchas}");
        }
    }
}
