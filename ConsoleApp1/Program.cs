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

            Gitarre wasEllenMag = new Gitarre("", 0, "fender", "Stratocastor",
                                                "elektrisch", "Erle", "Erle");
            Gitarre gefunden = bestand.Suchen(wasEllenMag);
            if (gefunden != null)
            {
                Console.WriteLine("Das könnte dir gefallen, Ellen: ");
                Console.WriteLine(gefunden.Typ);
                Console.WriteLine(gefunden.Hersteller);
                Console.WriteLine(gefunden.Modell);
                Console.WriteLine(gefunden.Bodenholz);
                Console.WriteLine(gefunden.Deckenholz);
                Console.WriteLine(gefunden.Preis);
            }
            else
            {
                Console.WriteLine("Leider nichts gefunden");
            }

            Console.ReadLine();

        }

        private static void bestandInitialisieren(Bestand bestand)
        {
            bestand.AddGitarre("v95693", 1499.95, "Fender", "Stratocastor", "elektrisch", "Erle",
                                "Erle");
        }
    }
}
