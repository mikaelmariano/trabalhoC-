using System;

namespace LojaOnline.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeEmEstoque += quantidade;
                Console.WriteLine($"{quantidade} unidades adicionadas ao estoque de {Nome}. Quantidade atual: {QuantidadeEmEstoque}");
            }
            else
            {
                Console.WriteLine("A quantidade a ser adicionada não pode ser negativa.");
            }
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                if (QuantidadeEmEstoque >= quantidade)
                {
                    QuantidadeEmEstoque -= quantidade;
                    Console.WriteLine($"{quantidade} unidades removidas do estoque de {Nome}. Quantidade atual: {QuantidadeEmEstoque}");
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente no estoque.");
                }
            }
            else
            {
                Console.WriteLine("A quantidade a ser removida deve ser positiva.");
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * QuantidadeEmEstoque;
        }
    }
}
