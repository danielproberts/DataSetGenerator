using System;
using System.IO;

namespace DataSetGenerator
{
    class Program
    {
        static string fileName;
        static void Main(string[] args)
        {
            Console.Write("Please input data set array size: ");
            string arraySizeString = Console.ReadLine();
            int arraySize = Int32.Parse(arraySizeString);
            int[] arr1 = new int[arraySize];
            Random randNum = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = randNum.Next(0, 10000);
            }

            fileName = @"dataset.txt";

            using (StreamWriter writeFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    writeFile.WriteLine(arr1[i]);
                }
            }

            Console.WriteLine(FileLineCount(fileName).ToString() + " items in dataset.txt");

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        static int FileLineCount(string filename)
        {
            int linecounter = 0;
            string line;
            using (StreamReader readFile = new StreamReader(filename))
            {
                while ((readFile.ReadLine()) != null)
                {
                    linecounter++;
                }
                readFile.Close();
            }
            return linecounter;
        }
    }
}
