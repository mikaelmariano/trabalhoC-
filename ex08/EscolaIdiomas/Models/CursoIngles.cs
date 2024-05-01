namespace Models
{
    public class CursoIngles : Curso
    {
        public CursoIngles(string nome, string instrutor, int duracaoHoras)
            : base(nome, instrutor, duracaoHoras)
        {
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Curso de Inglês:\nNome: {Nome}\nInstrutor: {Instrutor}\nDuração: {DuracaoHoras} horas\nConcluído: {Concluido}");
        }

        public override void GerarCertificado()
        {
            if (Concluido)
            {
                Console.WriteLine($"Certificado de conclusão do curso '{Nome}' em Inglês.");
            }
            else
            {
                Console.WriteLine($"O curso '{Nome}' ainda não foi concluído.");
            }
        }
    }
}
