using System;
using Models;

public class Program
{
    public static void Main(string[] args)
    {       
        Carro carro = new Carro("Toyota", "Corolla", 2022, 4);
        Moto moto = new Moto("Honda", "CB500", 2021, 500);
        Bicicleta bicicleta = new Bicicleta("Giant", "Defy", 2023, 18);

        Console.WriteLine("Informações do Carro:");
        carro.ExibirInfo();

        Console.WriteLine("\nInformações da Moto:");
        moto.ExibirInfo();

        Console.WriteLine("\nInformações da Bicicleta:");
        bicicleta.ExibirInfo();
    }
}
