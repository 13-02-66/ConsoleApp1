using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gitarre
    {
        private string _seriennummer;
        private double _preis;
        private GitarrenDaten _daten;

        public Gitarre(string seriennummer, double preis, GitarrenDaten dat)
        {
            this._seriennummer = seriennummer;
            this._preis = preis;
            this._daten = dat;
        }

        public string getSeriennummer()
        { 
            return _seriennummer; 
        }
        public double getPreis()
        {
            return _preis;
        }
        public void setPreis(double neuerPreis)
        {
            this._preis = neuerPreis;    
        }
        public GitarrenDaten getDaten()
        {
            return _daten;
        }

    }
}
