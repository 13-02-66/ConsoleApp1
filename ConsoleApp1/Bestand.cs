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

        public void addGitarre(string seriennummer, double preis, Hersteller hersteller,
                                string modell, Typ typ, Holz bodenholz, Holz deckenholz)
        { 
            Gitarre gitarre = new Gitarre(seriennummer, preis, hersteller, modell, typ,
                                            bodenholz, deckenholz) ;
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

        public List<Gitarre> Suchen(Gitarre suchGitarre)
        {  
            List<Gitarre> passendeGitarren = new List<Gitarre>();   
            for (int i = 0; i < gitarren.Count; i++)
            {
                Gitarre gitarre = gitarren[i];
                if(suchGitarre.getHersteller() != gitarre.getHersteller())
                    continue;
                string modell = suchGitarre.getModell();
                if ((modell != null) && (modell != "") &&
                        (modell != gitarre.getModell()))
                    continue;
                if (suchGitarre.getTyp() != gitarre.getTyp())
                    continue;
                if (suchGitarre.getBodenHolz() != gitarre.getBodenHolz())
                    continue;
                if (suchGitarre.getDeckenHolz() != gitarre.getDeckenHolz())
                    continue;
                passendeGitarren.Add(gitarre);
            }
            return passendeGitarren;  
        }
          
    }
}
