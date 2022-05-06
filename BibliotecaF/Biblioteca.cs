using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProiectPIU.BibliotecaF {

    using Persoane;
    using System;
    using System.Globalization;


    public static class Biblioteca {
        public delegate void ModificareNumarCarti();
        public static ModificareNumarCarti OnModificareNumarCarti = NumarCartiModificat;


        private const int NUMAR_BIBLIOTECARI = 3;
        private const int ORA_DESCHIDERE = 8;
        private const int ORA_INCHIDERE = 16;

        private static Bibliotecar[] personal;
        private static readonly bool bibliotecaDeschisa;

        public static System.Collections.Generic.List<Carte> carti;


        public static Tuple<int, int> ProgramLucru {

            get {

                var Date = new Tuple<int, int>(ORA_DESCHIDERE, ORA_INCHIDERE);

                return Date;
            }
        }

        public static bool BibliotecaDeschisa {
            get {
                return bibliotecaDeschisa;
            }
        }


        static Biblioteca() {

            personal = new Bibliotecar[NUMAR_BIBLIOTECARI] {

                new Bibliotecar("Felicia Olaru", "18/01/1988"),
                new Bibliotecar("Ana-Maria Prelipceanu", "22/08/1978"),
                new Bibliotecar("Oana Vacarescu", "15/03/1980")
            };

            carti = new System.Collections.Generic.List<Carte>();

            string ziuaCurenta = DateTime.Now.DayOfWeek.ToString();
            int oraCurenta = DateTime.Now.Hour;

            bibliotecaDeschisa = true;

            if (ziuaCurenta == "Saturday" || ziuaCurenta == "Sunday") bibliotecaDeschisa = false;

            if (!(oraCurenta >= 8 && oraCurenta <= 16)) bibliotecaDeschisa = false;



        }

        public static void NumarCartiModificat() {

            Console.WriteLine("Numarul de carti a fost modificat!");
        }



    }
}
