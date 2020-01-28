using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Storlekar = new int[] { 10, 1000, 100000 }; // Det är en array med storlekar 
            for (int i = 0; i < Storlekar.Length; i++)
            {
                Console.WriteLine("Skapar slumpad data av längd " + Storlekar[i]); //Skirver hur många tal som skall sorteras
                int[] data = GenereraData(Storlekar[i]); // skapar en array som generarar element och skpar en metod
                Console.WriteLine("Sorterar slumpad data");
                DateTime startTid = DateTime.Now;  // Tiden för när sorteringen börjar 
                InsertionSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera.\n", deltaTid.TotalMilliseconds); // \n Tar en ny tom rad
                
            }
        }

        // Det här metoden är för att slumpa talen och den genereras av datorn själv
        static int[] GenereraData(int size)
        {
            Random rnd = new Random();
            int[] data = new int[size];
            for (int i = 0; i < data.Length; i++)
                data[i] = rnd.Next(data.Length);
            return data;
        }


        static void InsertionSort(int[] data)
        {
            //Gör en loop för varje tal som skall sorteras börja på index 1 då vi kommer att titta "bakåt" i vektorn

            for (int i = 1; i < data.Length; i++)
            {
                //Stega bakåt från position i ned till 1 om det behövs
                for (int j = i; j > 0; j--)
                {
                    //jämför med talet "bakom" och se om det är större
                    if (data[j] < data[j - 1])
                    {
                        //byter plats på tal
                        int temp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = temp;
                    }
                    //annars avsluta innerloopen 
                    else
                        break;
                }
            }
        }
    }
}