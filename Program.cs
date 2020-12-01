using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
            int[] zeroThruNine = new int[10];
            for (int i = 0; i < 10; i++)
            {
                zeroThruNine[i] = i;
            }

            string[] names = {"Tim", "Martin", "Nikki", "Sara"};

            bool[] altTf = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    altTf[i] = true;
                }
                else
                {
                    altTf[i] = false;
                }
            }

            //List of Flavors
            List<string> flavors = new List<string>
            {
                "Mint Chocolate Chip",
                "Strawberry",
                "Coffee",
                "Fudge Brownie",
                "Phish Food"
            };
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            //User Info Dictionary
            Dictionary<string,string> nameKeys = new Dictionary<string, string>();
            foreach (var name in names)
            {
                nameKeys.Add(name, null);
            }
            Random rand = new Random();
            foreach (var name in names)
            {
                int randInx = rand.Next(flavors.Count - 1);
                nameKeys[name] = flavors[randInx];
                flavors.RemoveAt(randInx);
            }

            foreach (var entry in nameKeys)
            {
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }
        }
    }
}
