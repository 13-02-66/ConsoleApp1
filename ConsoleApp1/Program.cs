using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GitarrenSuchTest
    {
        static void Main(string[] args)
        {
            Bestand bestand = new Bestand();
            bestandInitialisieren(bestand);

            Gitarre wasEllenMag = new Gitarre("", 0, Hersteller.FENDER, "Stratocastor",
                                                Typ.ELEKTRISCH, Holz.ERLE, Holz.ERLE);
           
            List<Gitarre> passendeGitarren = bestand.Suchen(wasEllenMag);
            if (passendeGitarren.Count != 0)
            {
                for (int i = 0; i < passendeGitarren.Count; i++)
                {
                    Gitarre gitarre = passendeGitarren[i];
                    Console.WriteLine("Das könnte dir gefallen, Ellen: ");
                    Console.WriteLine(gitarre.getTyp());
                    Console.WriteLine(gitarre.getModell());
                    Console.WriteLine(gitarre.getHersteller());
                    Console.WriteLine(gitarre.getBodenHolz());
                    Console.WriteLine(gitarre.getDeckenHolz());
                    Console.WriteLine(gitarre.getPreis());
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                }
                
            }
            else
            {
                Console.WriteLine("Leider nichts gefunden");
            }

            Console.ReadLine();

        }

        private static void bestandInitialisieren(Bestand bestand)
        {
            bestand.addGitarre("V95693", 1499.95, Hersteller.FENDER, "Stratocastor",
                                Typ.ELEKTRISCH, Holz.ERLE, Holz.ERLE);
            bestand.addGitarre("V9512", 1565.95, Hersteller.FENDER, "Stratocastor", Typ.ELEKTRISCH, Holz.ERLE,
                                Holz.ERLE);
        }
    }
}
