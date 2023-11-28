using ConsoleApp5;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IDzwiek> Idzwiek = new List<IDzwiek>();
        Idzwiek.Add(new Samochod());
        Idzwiek.Add(new Telefon());
        foreach (IDzwiek idzwiek_ in Idzwiek)
        {
            idzwiek_.OdtwarzajDzwiek();
        }

    }
    
}
public static class UzytkownikExtension
    {
        public static void Loguj(this Uzytkownik uzytkownik)
        {

        }
    }