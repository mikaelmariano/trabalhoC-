using System;
using Models;

public class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente cc = new ContaCorrente("123-CC", "Mikael", 1000);
        ContaPoupanca cp = new ContaPoupanca("124-CP", "Elenice", 2000, 3.5);
        ContaEmpresarial ce = new ContaEmpresarial("125-CE", "Studio", 5000, 1000);

        Console.WriteLine("Informações da Conta Corrente:");
        cc.ExibirInfo();

        Console.WriteLine("\nInformações da Conta Poupança:");
        cp.ExibirInfo();
        cp.CalcularJuros();

        Console.WriteLine("\nInformações da Conta Empresarial:");
        ce.ExibirInfo();

        Console.WriteLine("\nOperações:");
        cc.Depositar(200);
        cc.Sacar(300);

        cp.Sacar(500);

        ce.Sacar(4000);
        ce.Sacar(1000);
    }
}
