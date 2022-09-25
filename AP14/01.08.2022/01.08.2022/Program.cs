using System;

namespace _01._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Bearbeitung
            string namen = "Peter;Max;Erika;Felix";

            //Splitten
            string[] namenListe = namen.Split(';');


            //Möglichkeit 1:
            //for (int i = 0; i < namenListe.Length; i++)
            //{
            //    Console.WriteLine(namenListe[i]);
            //}

            //Möglichkeit 2

            //foreach (var item in namenListe)
            //{
            //    Console.WriteLine(ite);
            //}

            //Möglichkeit 3

            //string ausgabe = string.Join("\n", namenListe);

            //Console.WriteLine(ausgabe);

            //Namen sortieren "Max;Erika;Felix"

            //Möglichkeit 1:

            //Console.WriteLine("-----Vorher----");
            //foreach (string eintrag in namenListe)
            //{
            //    Console.WriteLine(eintrag);
            //}
            //Array.Sort(namenListe);
            //Console.WriteLine("-----Nacher-----");
            //foreach (var eintrag in namenListe)
            //{
            //    Console.WriteLine(eintrag);
            //}

            //Möglichkeit 2


            for (int j = 0; j < namenListe.Length - 1; j++)
            {
                for (int i = 0; i < namenListe.Length - 1; i++)
                {
                    char Wort1Zeichen1 = namenListe[i][0];
                    char Wort2Zeichen1 = namenListe[i + 1][0];

                    if (Wort1Zeichen1 > Wort2Zeichen1)
                    {
                        string zsp = namenListe[i];
                        namenListe[i] = namenListe[i + 1];
                        namenListe[i + 1] = zsp;
                    }
                }
            }

            foreach (var item in namenListe)
            {
                Console.WriteLine(item);
            }
        }
    }
}
