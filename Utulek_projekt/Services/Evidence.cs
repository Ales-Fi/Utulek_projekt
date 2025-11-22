using System;
using System.Collections.Generic;

public class Evidence
{
    private List<Zvire> Zvirata = new List<Zvire>();

    // Přidání zvířete
    public void PridejZvire(KonzoleUI ui)
    {
        Zvirata.Add(new Zvire(
            ui.Jmeno,
            ui.Druh,
            ui.Vek,
            ui.Pohlavi,
            ui.DatumPrijmu,
            ui.ZdravotniStav,
            ui.Poznamka
        ));

        Console.WriteLine("✔ Zvíře bylo přidáno.");
    }

    // Výpis všech zvířat
    public void VypisZvirata()
    {
        if (Zvirata.Count == 0)
        {
            Console.WriteLine("Žádná zvířata v evidenci.");
            return;
        }

        foreach (var zv in Zvirata)
        {
            Console.WriteLine(zv);
        }
    }

    // Vyhledávání (nejzákladnější verze)
    public void Vyhledat(KonzoleUI ui)
    {
        string hledat = ui.VyhledavaciText;

        if (string.IsNullOrEmpty(hledat))
        {
            Console.WriteLine("Nezadal jsi text pro vyhledávání.");
            return;
        }

        bool nalezeno = false;

        foreach (var zv in Zvirata)
        {
            // Převést na malé písmo kvůli ignorování velikosti
            string jmeno = zv.Jmeno.ToLower();
            string druh = zv.Druh.ToLower();
            string dotaz = hledat.ToLower();

            if (jmeno.Contains(dotaz) || druh.Contains(dotaz))
            {
                Console.WriteLine(zv);
                nalezeno = true;
            }
        }

        if (!nalezeno)
            Console.WriteLine("Nic nenalezeno.");
    }

    // Označení adopce
    public void OznacitAdopci(KonzoleUI ui)
    {
        Zvire zvire = null;

        foreach (var z in Zvirata)
        {
            if (z.Jmeno.ToLower() == ui.JmenoProAdopci.ToLower())
            {
                zvire = z;
                break;
            }
        }

        if (zvire == null)
        {
            Console.WriteLine("Zvíře nenalezeno.");
            return;
        }

        if (zvire.Adoptovano)
        {
            Console.WriteLine("Toto zvíře je už adoptováno.");
            return;
        }

        zvire.Adoptovano = true;
        Console.WriteLine("✔ Zvíře bylo označeno jako adoptované.");
    }

    // Statistiky
    public void Statistic()
    {
        Console.WriteLine($"Celkový počet zvířat: {Zvirata.Count}");

        int pocetAdoptovanych = 0;
        foreach (var z in Zvirata)
        {
            if (z.Adoptovano)
                pocetAdoptovanych++;
        }
        Console.WriteLine($"Počet adoptovaných: {pocetAdoptovanych}");

        // Počty podle druhu
        Dictionary<string, int> podleDruhu = new Dictionary<string, int>();
        foreach (var z in Zvirata)
        {
            if (podleDruhu.ContainsKey(z.Druh))
                podleDruhu[z.Druh]++;
            else
                podleDruhu[z.Druh] = 1;
        }

        Console.WriteLine("Počty podle druhu:");
        foreach (var entry in podleDruhu)
        {
            Console.WriteLine($"   {entry.Key}: {entry.Value}");
        }
    }
}
