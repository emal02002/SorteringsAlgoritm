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
            int[] sizes = new int[] { 10, 1000, 100000 }; // Det är en array med olika storlekar
            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine("Skapar slumpad data av längd " + sizes[i]); //Skirver hur många tal som skall sorteras
                int[] data = GenerateData(sizes[i]); // skapar en array som generarar element och skpar en metod
                Console.WriteLine("Sorterar slumpad data");
                DateTime startTid = DateTime.Now; // Tiden för när sorteringen börjar
                BubbleSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera.\n", deltaTid.TotalMilliseconds); // \n Tar en ny tom rad
                
            }
        }
        // Det här metoden är för att slumpa talen och den genereras av datorn själv
        static int[] GenerateData(int size)
        {
            Random rnd = new Random();
            int[] data = new int[size];
            for (int i = 0; i < data.Length; i++)
                data[i] = rnd.Next(data.Length);
            return data;
        }


        static void BubbleSort(int[] data)
        {
            bool BehoverSortering = true;
            //Gör en loop för varje tal som skall sorteras, avbryt om talen är sorterade
            for (int i = 0; i < data.Length - 1 && BehoverSortering; i++)
            {
                //Signalera att vi börjar om en ny vända med sortering
                BehoverSortering = false;
                //Gå igenom alla tal fram till och med de tal som ev. 
                //redan är sorterade (variabeln i)
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    //Flytta större tal fram i vektorn
                    if (data[j] > data[j + 1])
                    {
                        //Signalera att vi kommer att behöva fortsätta sortera
                        BehoverSortering = true;
                        //Byt plats på tal
                        int tmp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = tmp;
                    }
                }
            }
        }
    }
}