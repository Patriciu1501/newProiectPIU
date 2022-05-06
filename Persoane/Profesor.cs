using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProiectPIU.Persoane {
    class Profesor:Persoana {
        private List<string> discipline;

        public List<string> Discipline {
            get {
                return discipline;
            }

            private set {

            }
        }

        public override void ImprumutaCarte(int durata, string categorie, string denumire = "") {

        }

        public override void ReturneazaCarte() {
            throw new NotImplementedException();
        }
    }
}
