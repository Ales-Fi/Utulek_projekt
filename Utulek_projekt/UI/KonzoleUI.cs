using System;

public class KonzoleUI
{
    public string Jmeno { get; private set; }
    public string Druh { get; private set; }
    public int Vek { get; private set; }
    public string Pohlavi { get; private set; }
    public DateTime DatumPrijmu { get; private set; }
    public string ZdravotniStav { get; private set; }
    public string Poznamka { get; private set; }

    public string VyhledavaciText { get; private set; }
    public string JmenoProAdopci { get; private set; }

    public int NacteniVolby()
    {
        while (true)
        {
            string vstup = Console.ReadLine();
            if (int.TryParse(vstup, out int cislo))
                return cislo;

            Console.Write("Zadej číslo: ");
        }
    }

    public void NacteniInfo()
    {
        Console.Write("Jméno: ");
        Jmeno = Console.ReadLine();

        Console.Write("Druh: ");
        Druh = Console.ReadLine();

        Console.Write("Věk (číslo): ");
        Vek = NactiInt();

        Console.Write("Pohlaví: ");
        Pohlavi = Console.ReadLine();

        Console.Write("Datum příjmu (dd.mm.yyyy): ");
        DatumPrijmu = NactiDatum();

        Console.Write("Zdravotní stav: ");
        ZdravotniStav = Console.ReadLine();

        Console.Write("Poznámka (nepovinné): ");
        Poznamka = Console.ReadLine();
    }

    public void NacteniVyhledavani()
    {
        Console.Write("Zadej jméno nebo druh: ");
        VyhledavaciText = Console.ReadLine();
    }

    public void NacteniJmenaProAdopci()
    {
        Console.Write("Zadej jméno zvířete k adopci: ");
        JmenoProAdopci = Console.ReadLine();
    }

    private int NactiInt()
    {
        while (true)
        {
            string vstup = Console.ReadLine();
            if (int.TryParse(vstup, out int cislo))
                return cislo;

            Console.Write("Zadej platné číslo: ");
        }
    }

    private DateTime NactiDatum()
    {
        while (true)
        {
            string vstup = Console.ReadLine();
            if (DateTime.TryParse(vstup, out DateTime datum))
                return datum;

            Console.Write("Zadej platné datum (dd.mm.yyyy): ");
        }
    }
}
