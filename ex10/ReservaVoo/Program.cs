using System;
using Models;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        ReservaRegular reservaRegular = new ReservaRegular("Voo A123", "Mikael");
        ReservaUpgrade reservaUpgrade = new ReservaUpgrade("Voo B456", "Elenice", "Executiva");
        ReservaGrupo reservaGrupo = new ReservaGrupo("Voo C789", new List<string> { "Mizael", "a", "Pedro" });

        reservaRegular.Reservar();
        reservaUpgrade.Reservar();
        reservaGrupo.Reservar();

        Console.WriteLine(reservaRegular.VerificarStatus());
        Console.WriteLine(reservaUpgrade.VerificarStatus());
        Console.WriteLine(reservaGrupo.VerificarStatus());

        reservaUpgrade.Cancelar();

        Console.WriteLine(reservaUpgrade.VerificarStatus());
    }
}
