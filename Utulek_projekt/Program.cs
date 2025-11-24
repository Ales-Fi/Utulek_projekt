using System;

internal class Program
{
    static void Main(string[] args)
    {
        KonzoleUI ui = new KonzoleUI();
        Evidence evidence = new Evidence();

        int volba = -1;

        while (volba != 0)
        {
            Console.WriteLine("===== ÚTULEK PRO ZVÍŘATA =====");
            Console.WriteLine("1) Přidat zvířátko | 2) Vypsat všechna zvířátka | 3) Vyhledat/filtrovat | 4) Označit adopci | 5) Statistiky | 0) Konec");
            Console.Write("Volba: ");

            volba = ui.NacteniVolby();

            switch (volba)
            {
                case 1:
                    ui.NacteniInfo();
                    evidence.PridejZvire(ui);
                    break;

                case 2:
                    evidence.VypisZvirata();
                    break;

                case 3:
                    ui.NacteniVyhledavani();
                    evidence.Vyhledat(ui);
                    break;

                case 4:
                    ui.NacteniJmenaProAdopci();
                    evidence.OznacitAdopci(ui);
                    break;

                case 5:
                    evidence.Statistic();
                    break;

                case 0:
                    Console.WriteLine("Ukončuji program...");
                    break;

                default:
                    Console.WriteLine("Neplatná volba!");
                    break;
            }

            Console.WriteLine();
        }
    }
}
