using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Utulek_projekt.UI
{
    internal class KonzoleUI
    {
        public int Id;
        public string Jmeno;
        public string Druh;
        public int Vek;
        public string Pohlavi;
        public bool Adoptovano = false;


        public sbyte NacteniVolby()
        {
            if (sbyte.TryParse(Console.ReadLine(), out sbyte volba))
            {
                return volba;
            }
            else 
            {
                return 0;
            }
        }

        public void NacteniInfo()
        {
            Console.Write("Zadejte id zvířátka: ");
            if ((int.TryParse(Console.ReadLine(), out int id)) && (id > 0))
            {
                Id = id;
            }
            else
            {
                Console.WriteLine("Neplatný vstup pro ID");
            }
            Console.Write("Zadejte jméno zvířátka: ");
            Jmeno = Console.ReadLine();
            Console.Write("Zadejte druh zvířátka: ");
            Druh = Console.ReadLine();
            Console.Write("Zadejte věk zvířátka: ");
            if ((int.TryParse(Console.ReadLine(), out int vek)) && (vek > 0))
            {
                Vek = vek;
            }
            else
            {
                Console.WriteLine("Neplatný vstup pro věk");
            }
            Console.Write("Zadejte pohlaví zvířátka: ");
            Pohlavi = Console.ReadLine();
            Adoptovano = false;
            Console.WriteLine("Zvířátko bylo úspěšně přidáno.");

            //přidat do listu zvířátek
        }
    }
}
