namespace Models
{
    public class CursoFrances : Curso
    {
        public CursoFrances(string nome, string instrutor, int duracaoHoras)
            : base(nome, instrutor, duracaoHoras)
        {
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Curso de Francês:\nNome: {Nome}\nInstrutor: {Instrutor}\nDuração: {DuracaoHoras} horas\nConcluído: {Concluido}");
        }

        public override void GerarCertificado()
        {
            if (Concluido)
            {
                Console.WriteLine($"Certificado de conclusão do curso '{Nome}' em Francês.");
            }
            else
            {
                Console.WriteLine($"O curso '{Nome}' ainda não foi concluído.");
            }
        }
    }
}
