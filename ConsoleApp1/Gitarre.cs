using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Typ
    {
        AKUSTISCH, ELEKTRISCH
    }
    public enum Hersteller
    {
        FENDER, MARTIN, GIBSON, COLLINGS, 
        OLSON, RYAN, PRS, BELIEBIG
    }
    public enum Holz
    {
        INDISCHER_PALISANDER, RIO_PALISANDER, MAHAGONI,
            AHORN, COCOBOLO, ZEDER, ADRIONDACK, ERLE, STIKA
    }
    public class Gitarre
    {
        private string _seriennummer;
        private Hersteller _hersteller;
        private string _modell;
        private Typ _typ;
        private Holz _bodenholz;
        private Holz _deckenholz;

        private double _preis;

        public Gitarre(string seriennummer, double preis, Hersteller hersteller, string modell,
                        Typ typ, Holz bodenholz, Holz deckenholz)
        {
            this._seriennummer = seriennummer;
            this._preis = preis;
            this._hersteller = hersteller;
            this._modell = modell;
            this._typ = typ;    
            this._bodenholz = bodenholz;
            this._deckenholz = deckenholz;
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
        public Hersteller getHersteller()
        {
            return _hersteller;
        }
        public string getModell()
        {
            return _modell;    
        }
        public Typ getTyp()
        {
            return _typ;
        }
        public Holz getBodenHolz()
        {
            return _bodenholz;   
        }
        public Holz getDeckenHolz()
        {
            return _deckenholz;
        }

    }
}
