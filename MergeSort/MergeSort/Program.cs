using System;

namespace MergeSort
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
                MergeSort(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} ms att sortera.\n", deltaTid.TotalMilliseconds); // \n Tar en ny tom rad

            }
        }
        static int[] GenerateData(int size)
        {
            Random rnd = new Random();
            int[] data = new int[size];
            for (int i = 0; i < data.Length; i++)
                data[i] = rnd.Next(data.Length);
            return data;
        }

        static void MergeSort(int[] data)
        {

        }
    }
}
