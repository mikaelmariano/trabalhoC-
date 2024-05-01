using System;
using Models;

public class Program
{
    public static void Main(string[] args)
    {
        CartaoCredito cartao = new CartaoCredito("9999-9999-9999-9999", "Mikael Mariano", "12/25");
        BoletoBancario boleto = new BoletoBancario("1234567890");
        TransferenciaBancaria transferencia = new TransferenciaBancaria("Banco A", "Conta A", "Banco B", "Conta B");

        cartao.RealizarPagamento(200.00);
        boleto.RealizarPagamento(150.00);
        transferencia.RealizarPagamento(300.00);

        Console.WriteLine(cartao.VerificarStatus());
        Console.WriteLine(boleto.VerificarStatus());
        Console.WriteLine(transferencia.VerificarStatus());
    }
}
