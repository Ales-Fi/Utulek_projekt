using System;

namespace Utulek_projekt.Model
{
    internal class Zvire
    {
        private static int _idCounter = 1;

        public int Id { get; private set; }
        public string Jmeno { get; private set; }
        public string Druh { get; private set; }
        public int Vek { get; private set; }
        public string Pohlavi { get; private set; }
        public bool Adoptovano { get; private set; } = false;
        public string ZdravotniStav { get; private set; }
        public string Poznamka { get; private set; }
        public DateTime DatumPrijmu { get; private set; }
        public DateTime? DatumAdopce { get; private set; }

        public Zvire(string jmeno, string druh, int vek, string pohlavi,
                     DateTime datumPrijmu, string zdravotniStav, string poznamka = "")
        {
            Id = _idCounter++;
            Jmeno = jmeno;
            Druh = druh;
            Vek = vek;
            Pohlavi = pohlavi;
            DatumPrijmu = datumPrijmu;
            ZdravotniStav = zdravotniStav;
            Poznamka = poznamka;
        }

        public void OznacitAdopci(DateTime datumAdopce)
        {
            Adoptovano = true;
            DatumAdopce = datumAdopce;
        }

        public void UpravitPoznamku(string novaPoznamka)
        {
            Poznamka = novaPoznamka;
        }

        public void ZmenitZdravotniStav(string novyStav)
        {
            ZdravotniStav = novyStav;
        }

        public bool ValidovatVek()
        {
            return Vek >= 0;
        }

        public override string ToString()
        {
            return
                $"ID: {Id} | " +
                $"Jméno: {Jmeno} | Druh: {Druh} | Věk: {Vek} let | " +
                $"Pohlaví: {Pohlavi} | " +
                $"Příjem: {DatumPrijmu:dd.MM.yyyy} | " +
                $"Adoptováno: {(Adoptovano ? "ANO" : "NE")}" +
                (Adoptovano && DatumAdopce.HasValue ? $" (dne {DatumAdopce:dd.MM.yyyy})" : "") +
                $" | Zdravotní stav: {ZdravotniStav}" +
                (string.IsNullOrWhiteSpace(Poznamka) ? "" : $" | Pozn.: {Poznamka}");
        }
    }
}