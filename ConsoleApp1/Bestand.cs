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

        public void AddGitarre(string seriennummer, double preis, string hersteller,
                                string modell, string typ, string bodenholz,
                                string deckenholz)
        {
            Gitarre gitarre = new Gitarre(seriennummer, preis, hersteller, modell, typ,
                                            bodenholz, deckenholz);
            gitarren.Add(gitarre);
        }

        public Gitarre GetGitarre(string seriennummer)
        {
            Gitarre result = null;
            foreach (var item in gitarren)
            {
                if (item.Seriennummer == seriennummer)
                {
                    result = item;
                }
            }
            return result;
        }

        public Gitarre Suchen(Gitarre suchGitarre)
        {

            for (int i = 0; i < gitarren.Count; i++)
            {
                Gitarre gitarre = gitarren[i];
                string hersteller = suchGitarre.Hersteller;
                if ((hersteller != null) && (!hersteller.Equals("")) &&
                    (!hersteller.Equals(gitarre.Hersteller)))
                    continue;
                string modell = suchGitarre.Modell;
                if ((modell != null) && (!modell.Equals("")) &&
                    (!modell.Equals(gitarre.Modell)))
                    continue;
                string typ = suchGitarre.Typ;
                if ((typ != null) && (!typ.Equals("")) &&
                    (!typ.Equals(gitarre.Typ)))
                    continue;
                string bodenholz = suchGitarre.Bodenholz;
                if ((bodenholz != null) && (!bodenholz.Equals("")) &&
                    (!bodenholz.Equals(gitarre.Bodenholz)))
                    continue;
                string deckenholz = suchGitarre.Deckenholz;
                if ((deckenholz != null) && (!deckenholz.Equals("")) &&
                    (!deckenholz.Equals(gitarre.Deckenholz)))
                    continue;
                return gitarre;
            }
            return null;  
        }
          
    }
}
