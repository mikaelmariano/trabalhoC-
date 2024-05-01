using System;
using Models;

public class Program
{
    public static void Main(string[] args)
    {
        CursoIngles ingles = new CursoIngles("Inglês Básico", "John Doe", 40);
        CursoEspanhol espanhol = new CursoEspanhol("Espanhol Intermediário", "Maria", 60);
        CursoFrances frances = new CursoFrances("Francês Avançado", "Pierre", 80);
        CursoAvancado avancado = new CursoAvancado("Inglês Avançado", "Jane Smith", 60);

        avancado.AdicionarNota(85);
        avancado.AdicionarNota(90);
        avancado.AdicionarNota(78);

        ingles.Concluir();
        frances.Concluir();

        Console.WriteLine("Informações dos Cursos:");
        ingles.ExibirInfo();
        espanhol.ExibirInfo();
        frances.ExibirInfo();
        avancado.ExibirInfo();

        Console.WriteLine("\nCertificados:");
        ingles.GerarCertificado();
        espanhol.GerarCertificado();
        frances.GerarCertificado();
        avancado.GerarCertificado();
    }
}
