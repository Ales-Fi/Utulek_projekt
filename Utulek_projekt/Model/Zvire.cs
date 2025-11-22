using System;

public class Zvire
{
    public string Jmeno { get; set; }
    public string Druh { get; set; }
    public int Vek { get; set; }
    public string Pohlavi { get; set; }
    public DateTime DatumPrijmu { get; set; }
    public string ZdravotniStav { get; set; }
    public string Poznamka { get; set; }
    public bool Adoptovano { get; set; }

    public Zvire(string jmeno, string druh, int vek, string pohlavi,
                 DateTime datumPrijmu, string zdravotniStav, string poznamka = "")
    {
        Jmeno = jmeno;
        Druh = druh;
        Vek = vek;
        Pohlavi = pohlavi;
        DatumPrijmu = datumPrijmu;
        ZdravotniStav = zdravotniStav;
        Poznamka = poznamka;
        Adoptovano = false;
    }

    public override string ToString()
    {
        return $"{Jmeno} ({Druh}), věk: {Vek}, pohlaví: {Pohlavi}, " +
               $"příjem: {DatumPrijmu.ToShortDateString()}, zdr.: {ZdravotniStav}, " +
               $"adopce: {(Adoptovano ? "ANO" : "NE")}";
    }
}
