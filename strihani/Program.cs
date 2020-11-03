using System;
using System.Runtime.CompilerServices;
public enum Vysledek { vyhrahrac, vyhrapc, nerozhodne }
//Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
//Neokopiroval jsem ani neopsal jsem cizí zdrojove kody
//Nikdo me pri vypracovani neradil
//Pokud nektery radek porusuje toto pravidlo je oznacek komentarem
//NENI MOJE TVORBA
//Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENI ZE STUDIA
// Cyril Steger uco. 36830
namespace strihani
{
    public class Program
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Jednoduchá hra: kamen - nuzky - papir");
            Console.WriteLine("Hrajeme na dve vitezna kola");

            int kola = 2;
            string input = "";

            Random r = new Random(); //Z prezentace

            string[] tahy = { "kamen", "nuzky", "papir" };
            int num = 0;
            int hrac = 0;
            int pocitac = 0;


            bool hrat_znova = true;
            {
                Console.WriteLine("Zadejte svuj tah:");
                Console.WriteLine("kamen\n" + "nuzky\n" + "papir");
                string tah = Console.ReadLine();


                if (int.TryParse(tah, out num))
                {
                    Console.WriteLine("Byla zadana spatna hodnota!");
                    Console.WriteLine("Zkuste to znovu");
                    return;
                }


                if (string.IsNullOrEmpty(input))
                {
                    for (int kolo = 1; kolo <= kola; kolo++)
                    {
                        Console.WriteLine("Hrac zahral: " + tah);
                        int randomcislo = r.Next(0, 3);
                        string randomtah = tahy[randomcislo];
                        Console.WriteLine("Pocitac zahral: " + randomtah);

                        Console.WriteLine("Zadejte svuj tah:");
                        string tahhrace = Console.ReadLine();
                        Console.WriteLine("Hrac zahral: " + tahhrace);
                        randomcislo = r.Next(0, 3);
                        randomtah = tahy[randomcislo];
                        Console.WriteLine("Pocitac zahral: " + randomtah);

                        switch (Vysledek)
                        {
                            case 0:
                                Console.WriteLine("Vyhra hrace!");
                                hrac++;
                                    break;
                            case 1:
                                Console.WriteLine("Vyhral pocitac!");
                                pocitac++;
                                    break;
                            case 3:
                                Console.WriteLine("Vysledek hry: nerozhodne!");
                                hrac++;
                                pocitac++;
                                    break;   
                        }
                    }
                }
            }
        }
    }
}

    

