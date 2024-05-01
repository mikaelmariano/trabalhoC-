using System;
using LojaOnline.Models;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("Notebook", 2299.00, 10);

        Console.WriteLine($"Valor total em estoque: {produto.ValorTotalEmEstoque()}");
        produto.AdicionarEstoque(5);
        Console.WriteLine($"Valor total em estoque: {produto.ValorTotalEmEstoque()}");
        produto.RemoverEstoque(7);
        Console.WriteLine($"Valor total em estoque: {produto.ValorTotalEmEstoque()}");
    }
}
