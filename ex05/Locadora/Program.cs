using System;
using Models;

public class Program
{
    public static void Main(string[] args)
    {
        Filme filme = new Filme("O Poderoso Chefão", "Drama", 175);

        Console.WriteLine($"Disponibilidade inicial de '{filme.Titulo}': {filme.EstaDisponivel()}");

        filme.RegistrarLocacao();
        Console.WriteLine($"Disponibilidade após locação: {filme.EstaDisponivel()}");

        filme.RegistrarDevolucao();
        Console.WriteLine($"Disponibilidade após devolução: {filme.EstaDisponivel()}");
    }
}
