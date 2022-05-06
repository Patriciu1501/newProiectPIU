
namespace newProiectPIU.AdministrareDate {

    using System;
    using System.IO;
    using System.Configuration;
    using System.Collections.Generic;
    public static class AdministrarePersoane_FisierText {

        private const string numeFisier = "Persoane.txt";

        static AdministrarePersoane_FisierText() {

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);

            streamFisierText.Close();
        }

        public static void AdaugarePersoana() {
            string numeComplet = string.Empty;
            string studentProfesor = string.Empty;
            string dataNasterii = string.Empty;
            int numarCartiImprumutate = 0;

            Console.Write("Nume complet: ");
            numeComplet = Console.ReadLine();
            Console.Write("Student sau profesor: ");
            studentProfesor = Console.ReadLine();
            Console.Write("Data nasterii(zz/ll/aaaa): ");
            dataNasterii = Console.ReadLine();
            Console.Write("Numar carti imprumutate: ");
            numarCartiImprumutate = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter fisier = new StreamWriter(numeFisier, true)) {

                fisier.WriteLine(numeComplet + ";" + dataNasterii + ";" + studentProfesor + ";" + numarCartiImprumutate);
            }

            Console.Clear();
            Console.WriteLine("Persoana a fost adaugata!");

        }

        public static List<string> GetFullDate() {
            var date = new List<string>();

            bool fisierGol = false;

            using (StreamReader fisier = new StreamReader(numeFisier)) {
                if (fisier.EndOfStream) fisierGol = true;

                while (!fisier.EndOfStream) {
                    date.Add(fisier.ReadLine());
                }
            }


            Console.Clear();

            if (!fisierGol) Console.WriteLine("Intregul fisier a fost citit!");

            else {

                Console.WriteLine("Fisierul este gol!");
                date.Add("Fisierul este gol!");
            }

            return date;
        }



        public static string getDateDupaNume(string nume) {
            string linieDate = null;

            using (StreamReader fisier = new StreamReader(numeFisier)) {
                while (!fisier.EndOfStream) {
                    string linieIntreaga = fisier.ReadLine();
                    string[] linieSeparata = linieIntreaga.Split(';');

                    if (linieSeparata[0] == nume) {
                        linieDate = linieIntreaga;
                        break;
                    }


                }
            }

            Console.Clear();

            if (linieDate == null) {
                linieDate = "Nu s-a putut gasi";
                Console.WriteLine(linieDate);
            }
            else Console.WriteLine("Datele dupa nume au fost preluate cu succes");


            return linieDate;

        }

    }
}
