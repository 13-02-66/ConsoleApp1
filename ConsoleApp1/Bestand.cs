using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;


namespace ConsoleApp1
{
    class Bestand
    {
        private List<Gitarre> gitarren;

        public Bestand()
        {
            gitarren = new List<Gitarre>();
        }

        public void addGitarre(string seriennummer, double preis, Hersteller herst, string mod,
                                Typ typ, Holz bodenh, Holz deckenh)
        { 
            GitarrenDaten daten = new GitarrenDaten(herst, mod, typ, bodenh, deckenh);
            Gitarre gitarre = new Gitarre(seriennummer, preis, daten) ;
            gitarren.Add(gitarre);
        }

        public Gitarre getGitarre(string seriennummer)
        {
            Gitarre result = null;
            foreach (var item in gitarren)
            {
                if (item.getSeriennummer() == seriennummer)
                {
                    result = item;
                }
            }
            return result;
        }

        public List<Gitarre> Suchen(GitarrenDaten suchDaten)
        {  
            List<Gitarre> passendeGitarren = new List<Gitarre>();   
            for (int i = 0; i < gitarren.Count; i++)
            {
                Gitarre gitarre = gitarren[i];
                GitarrenDaten gitarrenDaten = gitarre.getDaten();
                if(suchDaten.getHersteller() != gitarrenDaten.getHersteller())
                    continue;
                string modell = suchDaten.getModell();
                if ((modell != null) && (modell != "") &&
                        (modell != gitarrenDaten.getModell()))
                    continue;
                if (suchDaten.getTyp() != gitarrenDaten.getTyp())
                    continue;
                if (suchDaten.getBodenHolz() != gitarrenDaten.getBodenHolz())
                    continue;
                if (suchDaten.getDeckenHolz() != gitarrenDaten.getDeckenHolz())
                    continue;
                passendeGitarren.Add(gitarre);
  
            }
            return passendeGitarren;  
        }
          
    }
}
