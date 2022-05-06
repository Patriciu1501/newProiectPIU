using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProiectPIU.Persoane {
    public abstract class Persoana : IPersoana {
        const string DEFAULT_NUME = "Neinitializat";
        const string DEFAULT_DATAN = "Neinitializat";

        protected string nume;
        protected readonly string dataNasterii;
        protected int cartiImprumutate;

        public string Nume {
            get {
                return nume;
            }

            protected set {
                nume = value;
            }
        }
        public string DataNasterii {
            get {
                return dataNasterii;
            }
        }

        public int CartiImprumutate {
            get {
                return cartiImprumutate;
            }

            protected set {
                cartiImprumutate += value;
            }
        }


        protected Persoana(string nume = DEFAULT_NUME, string dataNasterii = DEFAULT_DATAN) {
            this.Nume = nume;
            this.dataNasterii = dataNasterii;
            this.CartiImprumutate = 0;
        }

        public override string ToString() {
            return Nume;
        }

        public abstract void ImprumutaCarte(int durata, string caregorie, string denumire);

        public abstract void ReturneazaCarte();
    }
}