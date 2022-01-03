using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GitarrenDaten
    {
        private string _hersteller;
        private string _modell;
        private string _typ;
        private string _bodenholz;
        private string _deckenholz;

        public string Hersteller
        {
            get
            {
                return _hersteller;
            }
            set
            {
                _hersteller = value.ToUpper();
            }
        }

        public string Modell
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
                _typ = value.ToUpper();
            }
        }
        public string Bodenholz
        {
            get
            {
                return _bodenholz;
            }
            set
            {
                _bodenholz = value.ToUpper();
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
                _deckenholz = value.ToUpper();
            }
        }

        public GitarrenDaten(string hersteller, string modell, string typ, string bodenholz, string deckenholz)
        {
            Hersteller = hersteller;
            Modell = modell;
            Typ = typ;
            Bodenholz = bodenholz;
            Deckenholz = deckenholz;
        }

    }
}


