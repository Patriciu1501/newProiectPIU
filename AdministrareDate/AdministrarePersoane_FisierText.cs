
namespace newProiectPIU.AdministrareDate {

    using System;
    using System.IO;
    using System.Configuration;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public static class AdministrarePersoane_FisierText {

        private const string numeFisier = "Persoane.txt";

        static AdministrarePersoane_FisierText() {

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);

            streamFisierText.Close();
        }

        public static void AdaugarePersoana(string nume, string prenume, string statut, string dataNasterii ) {
          
   

            using (StreamWriter fisier = new StreamWriter(numeFisier, true)) {

                fisier.WriteLine(nume + ";" + prenume + ";" + statut + ";" + dataNasterii);
            }

        }

        public static void GetFullDate(DataGridView grid) {

            grid.Rows.Clear();

            using (StreamReader fisier = new StreamReader(numeFisier)) {
  
                while (!fisier.EndOfStream) {
                    grid.Rows.Add(fisier.ReadLine().Split(';'));
                }
            }
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
