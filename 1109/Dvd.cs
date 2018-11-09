using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1109
{
    class Dvd: Kolcsonozheto,IComparable<Dvd>
    {
        string cim;
        int hossz; //perc

        public string Cim
        {
            get
            {
                return cim;
            }

            set
            {
                cim = value;
            }
        }

        public int Hossz
        {
            get
            {
                return hossz;
            }

            set
            {
                hossz = value;
            }
        }

        public Dvd(string cim, int hossz)
        {
            this.Cim = cim;
            this.Hossz = hossz;
        }

        public int MeddigKolcsonozheto()
        {
            return 7;
        }

        public string MegjelenitendoNev()
        {
            return this.Cim;

        }

        public double FutasIdoOra()
        {
            return Hossz / 60.0;

        }

        public int CompareTo(Dvd other)
        {
            if (this.hossz < other.hossz)
            {
                return -1;
            }
            else if (this.hossz > other.hossz)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
