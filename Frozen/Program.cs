using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class ChristmasWish
        {
            string name;
            string wish;

            public ChristmasWish(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            //getters for ChristmasWish
            public string Name
            {
                get { return name; }
            }

            public string Wish
            {
                get { return wish; }
            }
        }

        static void Main(string[] args)
        {
            List<ChristmasWish> wishes = new List<ChristmasWish>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                ChristmasWish newWish = new ChristmasWish(tempArray[0], tempArray[1]);
                wishes.Add(newWish);
            }

            foreach (ChristmasWish wishFromList in wishes)
            {
                Console.WriteLine($"{wishFromList.Name} wants {wishFromList.Wish} for Christmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
