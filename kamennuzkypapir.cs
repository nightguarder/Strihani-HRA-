using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
//Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
//Neokopiroval jsem ani neopsal jsem cizí zdrojove kody
//Nikdo me pri vypracovani neradil
//Pokud nektery radek porusuje toto pravidlo je oznacek komentarem
//NENI MOJE TVORBA
//Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENI ZE STUDIA
// Cyril Steger uco. 36830
namespace Priklad_3._6
{
    class kamennuzkypapir
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vitejte ve hre: kamen - nuzky - papir");
            Console.WriteLine("POCITAC VS HRAC");
            Console.WriteLine("Hrajeme na dve vitezna kola");
            Console.WriteLine("Zadejte svuj tah: \n" + "kamen\n" + "nuzky\n" + "papir\n");

            string hrac, pocitac;
            int Randomcislo;

            Random r = new Random(); //Z prezentace

            bool hrajznova = true;

            while (hrajznova)
            {
                int scorehrac = 0;
                int scorepc = 0;

                while (scorehrac < 2 && scorepc < 2)
                {

                    Console.Write("Zadejte svuj tah: ");
                    hrac = Console.ReadLine();
                    Randomcislo = r.Next(0, 3);

                    switch (Randomcislo)
                    {
                        case 0:
                            pocitac = "kamen";                          //Pocitac zahral: KAMEN
                            Console.WriteLine("Pocitac hraje: kamen");
                            if (hrac == "kamen")                        //Hrac zahraje: KAMEN
                            {
                                Console.WriteLine("Nerozhodně!\n");
                            }
                            else if (hrac == "papir")
                            {
                                Console.WriteLine("Hráč vyhral!\n");
                                scorehrac++;
                                Console.WriteLine("Skore hrac:  " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            else if (hrac == "nuzky")
                            {
                                Console.WriteLine("Pocitac vyhral!\n");
                                scorepc++;                              //skóre pocitac +1
                                Console.WriteLine("Skore hrac:  " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            break;

                        case 1:
                            pocitac = "nuzky";                          //Pocitac zahraje: NUZKY
                            Console.WriteLine("Pocitac hraje: nuzky");
                            if (hrac == "kamen")
                            {
                                Console.WriteLine("Hráč vyhral!\n");
                                scorehrac++;                    //skóre hrac +1
                                Console.WriteLine("Skore hrac: " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            else if (hrac == "nuzky")
                            {
                                Console.WriteLine("Nerozhodne!\n");

                            }
                            else if (hrac == "papir")
                            {
                                Console.WriteLine("Pocitac vyhral!\n");
                                scorepc++;
                                Console.WriteLine("Skore hrac:  " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            break;
                        case 2:
                            pocitac = "papir";
                            Console.WriteLine("Pocitac hraje: papir");
                            if (hrac == "papir")
                            {
                                Console.WriteLine("Nerozhodne!\n");
                            }
                            else if (hrac == "nuzky")
                            {
                                Console.WriteLine("Hrac vyhral!\n");
                                scorehrac++;
                                Console.WriteLine("Skore hrac:  " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            else if (hrac == "kamen")
                            {
                                Console.WriteLine("Pocitac vyhral!\n");
                                scorepc++;
                                Console.WriteLine("Skore hrac:  " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            break;
                        case 3:
                            pocitac = "papir";                      //Pocitac hraje: PAPIR
                            Console.WriteLine("Pocitac hraje: papir");
                            if (hrac == "papir")
                            {
                                Console.WriteLine("Nerozhodne!\n");
                            }
                            else if (hrac == "nuzky")
                            {
                                Console.WriteLine("Hrac vyhrál!");
                                scorehrac++;
                                Console.WriteLine("Skore hrac: " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            else if (hrac == "kamen")
                            {
                                Console.WriteLine("Pocitac vyhral!\n");
                                scorepc++;
                                Console.WriteLine("Score hrac: " + scorehrac + " Skore pocitac: " + scorepc);
                            }
                            break;
                        default:
                            Console.WriteLine("Spatny tah! Opakujte akci ");
                            break;
                    }
                    Console.WriteLine("Celkové skóre: \n" + "Hrac= " + scorehrac + " Pocitac= " + scorepc);
                }
                Console.WriteLine("Chcete hrát znova? yes/no");
                string odpoved = Console.ReadLine();
                if (odpoved == "yes")
                {
                    hrajznova = true;           //Program se spusti znovu od while(hrajznova)
                }
                else if (odpoved == "no")
                {
                    hrajznova = false;          //Program se ukonci
                    return;
                }

            }
        }
    }
}
