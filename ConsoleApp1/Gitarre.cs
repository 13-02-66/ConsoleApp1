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
        private string _hersteller;
        private string _modell;
        private string _typ;
        private string _bodenholz;
        private string _deckenholz;
        private double _preis;

        public string Seriennummer
        { get
            {
                return _seriennummer;
            }
            set
            {
                _seriennummer = value;
            }
        }
        public string Hersteller
        {
            get
            {
                return _hersteller;
            }
            set
            {
                _hersteller = value;
            }
        }

        public string  Modell
        {
            get 
            { 
                return _modell; 
            }
            set 
            { 
                _modell = value; 
            }
        }

        public string Typ
        {
            get 
            { 
                return _typ; 
            }
            set 
            { 
                _typ = value; 
            }
        }
        public string  Bodenholz
        {
            get 
            {
                return _bodenholz;  
            }
            set
            { 
                _bodenholz = value;
            }

        }
        public string Deckenholz
        {
            get 
            { 
                return _deckenholz; 
            }
            set
            { 
                _deckenholz = value; 
            }
        }

        public double Preis
        {
            get
            {
                return _preis;
            }
            set
            { 
                _preis = value; 
            }
        }

        public Gitarre(string seriennummer, double preis, string hersteller, string modell, string typ, string bodenholz, string deckenholz)
        {
            Seriennummer = seriennummer;
            Preis = preis;
            Hersteller = hersteller;
            Modell = modell;
            Typ = typ;
            Bodenholz = bodenholz;
            Deckenholz = deckenholz;
        }

        public Gitarre()
        {
        }
    }
}
