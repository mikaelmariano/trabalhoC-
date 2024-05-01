namespace Models
{
    public class CursoEspanhol : Curso
    {
        public CursoEspanhol(string nome, string instrutor, int duracaoHoras)
            : base(nome, instrutor, duracaoHoras)
        {
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Curso de Espanhol:\nNome: {Nome}\nInstrutor: {Instrutor}\nDuração: {DuracaoHoras} horas\nConcluído: {Concluido}");
        }

        public override void GerarCertificado()
        {
            if (Concluido)
            {
                Console.WriteLine($"Certificado de conclusão do curso '{Nome}' em Espanhol.");
            }
            else
            {
                Console.WriteLine($"O curso '{Nome}' ainda não foi concluído.");
            }
        }
    }
}
