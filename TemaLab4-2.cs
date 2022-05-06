using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProiectPIU {
    class TemaLab4_2 {

        private string[][] cuvinte;

        public TemaLab4_2(string[] argumente) {
            cuvinte = new string[26][];
            int[] index = new int[26];  // stocheaza numarul de elemente pentru fiecare arr din CUVINTE, initial toate 0


            for (int i = 0; i < 26; i++) cuvinte[i] = new string[100];

            for (int i = 0; i < argumente.Length; i++) {

                int indice = (int)char.ToLower(argumente[i][0]) - 97; // lucrez cu ascii

                cuvinte[indice][index[indice]++] = argumente[i];
            }

            for (int i = 0; i < cuvinte.Length; i++) {

                if (index[i] > 0) Console.WriteLine(new string('-', 20));

                for (int j = 0; j < index[i]; j++) {

                    Console.WriteLine(cuvinte[i][j]);
                }
            }
        }
    }
}
