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

            GitarrenDaten wasEllenMag = new GitarrenDaten(Hersteller.FENDER, "Stratocastor",
                                                Typ.ELEKTRISCH, Holz.ERLE, Holz.ERLE);
           
            List<Gitarre> passendeGitarren = bestand.Suchen(wasEllenMag);
            if (passendeGitarren.Count != 0)
            {
                for (int i = 0; i < passendeGitarren.Count; i++)
                {
                    Gitarre gitarre = passendeGitarren[i];
                    GitarrenDaten daten = gitarre.getDaten();   
                    Console.WriteLine("Das könnte dir gefallen, Ellen: ");
                    Console.WriteLine(daten.getTyp());
                    Console.WriteLine(daten.getModell());
                    Console.WriteLine(daten.getHersteller());
                    Console.WriteLine(daten.getBodenHolz());
                    Console.WriteLine(daten.getDeckenHolz());
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
