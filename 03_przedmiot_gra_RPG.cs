using System;

public enum Rzadkosc
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

public enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

public struct Przedmiot
{
    public double Waga;
    public int Wartosc;
    public Rzadkosc KlasaRzadkosci;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;

    public void WypelnijPrzedmiot(double waga, int wartosc, Rzadkosc rzadkosc, TypPrzedmiotu typ, string nazwa)
    {
        Waga = waga;
        Wartosc = wartosc;
        KlasaRzadkosci = rzadkosc;
        Typ = typ;
        NazwaWlasna = nazwa;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Przedmiot: " + NazwaWlasna);
        Console.WriteLine("Typ: " + Typ);
        Console.WriteLine("Rzadkosc: " + KlasaRzadkosci);
        Console.WriteLine("Waga: " + Waga);
        Console.WriteLine("Wartosc: " + Wartosc + " sztuk zlota");
        Console.WriteLine();
    }
}

public class Program
{
    private static Random random = new Random();

    public static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
    {
        int index = random.Next(przedmioty.Length);
        return przedmioty[index];
    }

    public static void Main(string[] args)
    {
        Przedmiot[] przedmioty = new Przedmiot[4];

        przedmioty[0].WypelnijPrzedmiot(2.5, 50, Rzadkosc.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        przedmioty[1].WypelnijPrzedmiot(3.2, 100, Rzadkosc.Rzadki, TypPrzedmiotu.Zbroja, "Zbroja płytowa");
        przedmioty[2].WypelnijPrzedmiot(1.8, 200, Rzadkosc.Unikalny, TypPrzedmiotu.Amulet, "Amulet mądrości");
        przedmioty[3].WypelnijPrzedmiot(0.5, 500, Rzadkosc.Epicki, TypPrzedmiotu.Pierscien, "Pierścień potęgi");

        for (int i = 0; i < przedmioty.Length; i++)
        {
            przedmioty[i].WyswietlInformacje();
        }

        Console.WriteLine("Losowy przedmiot:");
        Przedmiot losowyPrzedmiot = LosujPrzedmiot(przedmioty);
        losowyPrzedmiot.WyswietlInformacje();
    }
}
