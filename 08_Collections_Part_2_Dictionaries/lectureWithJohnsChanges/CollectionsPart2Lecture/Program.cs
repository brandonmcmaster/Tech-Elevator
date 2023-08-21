using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {

            Console.WriteLine("####################");
            Console.WriteLine("       HASHSET");
            Console.WriteLine("####################");
            Console.WriteLine();

            //create
            HashSet<string> names = new HashSet<string>();

            names.Add("John");
            names.Add("Brian");
            names.Add("Steve");
            names.Add("John");
            names.Add("John");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names.Count);
            Console.WriteLine();


            List<string> myNames = new List<string>();
            myNames.AddRange(names);

            myNames.Sort();

            foreach (string name in myNames)
            {
                Console.WriteLine(name);
            }




            //display

            //add to list

            //display

            Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

            // Declaring and initializing a Dictionary

            Dictionary<string, int> scores = new Dictionary<string, int>();

            // Adding an item to a Dictionary
            scores["bob"] = 56;
            scores["fred"] = 99;
            scores["david"] = 0;
            scores["fritz"] = 77;

            // Retrieving an item from a Dictionary

            Console.WriteLine(scores["fritz"]);

            Console.WriteLine("Please enter a search word: ");
            string search = Console.ReadLine();

            if (scores.ContainsKey(search))
            {
                Console.WriteLine(scores[search]);
            }
            else
            {
                Console.WriteLine("That key does not exist");
            }

            Console.WriteLine();
            // Retrieving just the keys from a Dictionary

            foreach (string name in scores.Keys)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            foreach (int score in scores.Values)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine();


            foreach(KeyValuePair<string,int> kvp in scores)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }

            Console.WriteLine();

            // Loop through and display keys

            // Check to see if a key already exists

            // Iterate through the key-value pairs in the Dictionary

            // Remove an element from the Dictionary

            scores.Remove("john");
            Console.WriteLine(scores.Count);
            scores.Remove("fritz");
            Console.WriteLine(scores.Count);


            // loop through again to show item was removed

        }
	}
}
