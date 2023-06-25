using System;

public struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NrIndeksu;
    public DateTime DataUrodzenia;
}

public struct Przedmiot
{
    public string Nazwa;
    public string Kod;
    public int ECTS;
    public string Prowadzacy;
}

public struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Specjalizacja;
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NrIndeksu = 12345;
        student.DataUrodzenia = new DateTime(1998, 5, 10);

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kod = "INF101";
        przedmiot.ECTS = 5;
        przedmiot.Prowadzacy = "Dr. Anna Nowak";

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.TytulNaukowy = "Dr.";
        nauczyciel.Specjalizacja = "Informatyka";

        Console.WriteLine("Student: {0} {1}", student.Imie, student.Nazwisko);
        Console.WriteLine("Nr indeksu: {0}", student.NrIndeksu);
        Console.WriteLine("Data urodzenia: {0}", student.DataUrodzenia.ToShortDateString());

        Console.WriteLine("Przedmiot: {0} ({1})", przedmiot.Nazwa, przedmiot.Kod);
        Console.WriteLine("ECTS: {0}", przedmiot.ECTS);
        Console.WriteLine("Prowadzący: {0}", przedmiot.Prowadzacy);

        Console.WriteLine("Nauczyciel akademicki: {0} {1}", nauczyciel.Imie, nauczyciel.Nazwisko);
        Console.WriteLine("Tytuł naukowy: {0}", nauczyciel.TytulNaukowy);
        Console.WriteLine("Specjalizacja: {0}", nauczyciel.Specjalizacja);
    }
}
