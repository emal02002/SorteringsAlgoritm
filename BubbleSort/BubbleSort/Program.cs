using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] strolekar = new int[] { 10, 1000, 100000 }; // Det är en array med olika storlekar
            for (int i = 0; i < strolekar.Length; i++) 
            {
                Console.WriteLine("Skapar slumpad data av längd " + strolekar[i]); //Skirver hur många tal som skall sorteras
                int[] lista = GenereraData(strolekar[i]); // skapar en array som generarar element och skpar en metod
                Console.WriteLine("Sorterar slumpad data");
                DateTime startTid = DateTime.Now; // Tiden för när sorteringen börjar
                BubbleSort(lista); //Skapar en metod för bubble sort for att sortera listan 
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera.\n", deltaTid.TotalMilliseconds); // \n Tar en ny tom rad
                
            }
        }
        // Det här metoden är för att slumpa talen och den genereras av datorn själv
        static int[] GenereraData(int storlek)
        {
            Random rnd = new Random();
            int[] lista = new int[storlek];
            for (int i = 0; i < lista.Length; i++)
                lista[i] = rnd.Next(lista.Length);
            return lista;
        }


        static void BubbleSort(int[] lista)
        {
            bool BehoverSortering = true;
            //Gör en loop för varje tal som skall sorteras, avbryt om talen är sorterade
            for (int i = 0; i < lista.Length - 1 && BehoverSortering; i++)
            {
                //Den gör att den kör om en ny runda efter första sorteringen
                BehoverSortering = false;
                //Gå igenom alla tal fram till och med de tal som ev redan är sorterade variabeln i

                for (int j = 0; j < lista.Length - 1 - i; j++)
                {
                    //Flytta större tal fram i arrayn
                    if (lista[j] > lista[j + 1])
                    {
                        //Signalera att vi kommer att behöva fortsätta sortera
                        BehoverSortering = true;
                        //Byt plats på tal
                        int tmp = lista[j + 1];
                        lista[j + 1] = lista[j];
                        lista[j] = tmp;
                    }
                }
            }
        }
    }
}