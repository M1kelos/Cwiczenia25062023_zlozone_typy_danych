using System;

public enum Plec
{
    Mezczyzna,
    Kobieta
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;

    public void WypelnijStudenta(string nazwisko, int nrAlbumu, double ocena, Plec plec)
    {
        Nazwisko = nazwisko;
        NrAlbumu = nrAlbumu;

        if (ocena < 2.0)
            Ocena = 2.0;
        else if (ocena > 5.0)
            Ocena = 5.0;
        else
            Ocena = ocena;

        Plec = plec;
    }

    public static double ObliczSrednia(Student[] grupa)
    {
        double sumaOcen = 0;
        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }

        return sumaOcen / grupa.Length;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Student: {Nazwisko}, Nr albumu: {NrAlbumu}, Ocena: {Ocena}, Płeć: {Plec}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student[] grupa = new Student[5];

        grupa[0].WypelnijStudenta("Kowalski", 12345, 4.5, Plec.Mezczyzna);
        grupa[1].WypelnijStudenta("Nowak", 54321, 3.7, Plec.Kobieta);
        grupa[2].WypelnijStudenta("Bak", 67890, 5.5, Plec.Mezczyzna);
        grupa[3].WypelnijStudenta("Jędrulski", 98765, 1.8, Plec.Kobieta);
        grupa[4].WypelnijStudenta("Wołodyjowski", 13579, 4.8, Plec.Mezczyzna);

        Console.WriteLine("Grupa studentów:");
        foreach (var student in grupa)
        {
            student.WyswietlInformacje();
        }

        double srednia = Student.ObliczSrednia(grupa);
        Console.WriteLine($"Średnia ocen w grupie: {srednia}");
    }
}
