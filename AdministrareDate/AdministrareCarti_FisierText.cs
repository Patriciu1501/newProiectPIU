
namespace newProiectPIU.AdministrareDate {

    using System;
    using System.IO;
    using System.Configuration;
    using System.Collections.Generic;


    public static class AdministrareCarti_FisierText {


        private const string numeFisier = "Carti.txt";

        static AdministrareCarti_FisierText() {

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);

            streamFisierText.Close();

        }

        public static void AdaugareCarte() {

            string denumire = string.Empty;
            string autor = string.Empty;
            string categorieText = string.Empty;
            string numarCarti = string.Empty;


            Console.Write("Denumire carte: ");
            denumire = Console.ReadLine();
            Console.Write("Autor: ");
            autor = Console.ReadLine();
            Console.Write("Categoria: ");
            categorieText = Console.ReadLine();
            Console.Write("Numar de astfel de carti: ");
            numarCarti = Console.ReadLine();


            using (StreamWriter fisier = new StreamWriter(numeFisier, true)) {

                fisier.WriteLine(denumire + ";" + autor + ";" + categorieText + ";" + numarCarti);
            }

            Console.Clear();
            Console.WriteLine("Cartea a fost adaugata!");
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


        public static string getDateDupaAutor(string autor) {
            string linieDate = null;

            using (StreamReader fisier = new StreamReader(numeFisier)) {
                while (!fisier.EndOfStream) {
                    string linieIntreaga = fisier.ReadLine();
                    string[] linieSeparata = linieIntreaga.Split(';');

                    if (linieSeparata[1] == autor) {
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
            else Console.WriteLine("Datele dupa autor au fost preluate cu succes");


            return linieDate;

        }

    }

}

