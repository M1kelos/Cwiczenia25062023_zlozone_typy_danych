using System;

public enum DniTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

public enum EtapyPrania
{
    Wypelnianie,
    Pioranie,
    Plukanie,
    Suszenie,
    Prasowanie
}

public enum Posilki
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

public enum BierkiSzachowe
{
    Krol,
    Hetman,
    Wieza,
    Goniec,
    Skoczek,
    Pion
}

public class Program
{
    public static void Main(string[] args)
    {
        DniTygodnia dzien = DniTygodnia.Sroda;
        Console.WriteLine("Dzisiejszy dzień to: " + dzien);

        EtapyPrania etap = EtapyPrania.Suszenie;
        Console.WriteLine("Aktualny etap prania: " + etap);

        Posilki posilek = Posilki.Obiad;
        Console.WriteLine("Dzisiejszy posiłek: " + posilek);

        BierkiSzachowe bierka = BierkiSzachowe.Skoczek;
        Console.WriteLine("Bierka w grze: " + bierka);
    }
}