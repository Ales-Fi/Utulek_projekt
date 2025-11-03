using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Utulek_projekt.UI;

namespace Utulek_projekt
{
    internal class Program
    {
     

        
        static void Main(string[] args)
        {
            KonzoleUI konzoleUI = new KonzoleUI();
            int volba;
            do {
                Console.WriteLine("===== ÚTULEK PRO ZVÍŘATA =====");
                Console.WriteLine("1) Přidat zvířátko | 2) Vypsat všechna zvířátka | 3) Vyhledat/filtrovat | 4) Označit adopci | 5) Statistiky | 0) Konec");
                Console.Write("Volba: ");
                volba = int.Parse(Console.ReadLine());
                switch (volba)
                {
                    case 1:
                        {
                            konzoleUI.Nacteni();
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Ukončeno...");
                            break;
                        }
                }
            } 
            while (volba != 0);
            Console.ReadKey();
        }
    }
}
