namespace Models
{
    public class CursoAvancado : Curso
    {
        public List<double> Notas { get; set; } = new List<double>();

        public CursoAvancado(string nome, string instrutor, int duracaoHoras)
            : base(nome, instrutor, duracaoHoras)
        {
        }

        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
            Console.WriteLine($"Nota {nota} adicionada ao curso '{Nome}'.");
        }

        public double CalcularMedia()
        {
            if (Notas.Count == 0)
            {
                Console.WriteLine("Nenhuma nota disponível para calcular a média.");
                return 0.0;
            }

            double media = Notas.Average();
            Console.WriteLine($"Média das notas do curso '{Nome}': {media}");
            return media;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Curso Avançado:\nNome: {Nome}\nInstrutor: {Instrutor}\nDuração: {DuracaoHoras} horas\nConcluído: {Concluido}");
            CalcularMedia();
        }

        public override void GerarCertificado()
        {
            if (Concluido)
            {
                Console.WriteLine($"Certificado de conclusão do curso '{Nome}' (Avançado).");
            }
            else
            {
                Console.WriteLine($"O curso '{Nome}' ainda não foi concluído.");
            }
        }
    }
}
