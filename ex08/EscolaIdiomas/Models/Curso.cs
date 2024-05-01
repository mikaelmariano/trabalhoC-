namespace Models
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public string Instrutor { get; set; }
        public int DuracaoHoras { get; set; }
        public bool Concluido { get; protected set; } 

        public Curso(string nome, string instrutor, int duracaoHoras)
        {
            Nome = nome;
            Instrutor = instrutor;
            DuracaoHoras = duracaoHoras;
            Concluido = false;
        }

        public void Concluir()
        {
            Concluido = true;
            Console.WriteLine($"O curso '{Nome}' foi concluído.");
        }

        public abstract void ExibirInfo();

        public abstract void GerarCertificado();
    }
}
