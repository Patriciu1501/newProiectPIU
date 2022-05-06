using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProiectPIU.Persoane {
    public interface IPersoana {

        string Nume { get; }
        string DataNasterii { get; }


        int CartiImprumutate { get; }

        void ImprumutaCarte(int durata, string categorie, string denumire);
        void ReturneazaCarte();
    }
}
