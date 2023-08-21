using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####################");
            Console.WriteLine("       LISTS");
            Console.WriteLine("####################");

            List<string> names = new List<string>();
            names.Add("Brandon");
            names.Add("John");
            names.Add("Steve");
            names.Add("Rachelle");


            Console.WriteLine("####################");
            Console.WriteLine("Lists are ordered");
            Console.WriteLine("####################");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("Lists allow duplicates");
            Console.WriteLine("####################");

            names.Add("John");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("Lists allow elements to be inserted in the middle");
            Console.WriteLine("####################");

            names.Insert(1, "Jarome");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();


            Console.WriteLine("####################");
            Console.WriteLine("Lists allow elements to be removed by index");
            Console.WriteLine("####################");

            names.RemoveAt(3);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            names.Remove("Brandon");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("Find out if something is already in the List");
            Console.WriteLine("####################");

            bool result = names.Contains("Rachelle");

            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("Find index of item in List");
            Console.WriteLine("####################");

            int index = names.IndexOf("Rachelle");
            Console.WriteLine(index);
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("Lists can be turned into an array");
            Console.WriteLine("####################");

            string[] namesInArray = names.ToArray();
            foreach (string name in namesInArray)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("Lists can be sorted");
            Console.WriteLine("####################");

            names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("Lists can be reversed too");
            Console.WriteLine("####################");

            names.Reverse();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine("####################");
            Console.WriteLine("       FOREACH");
            Console.WriteLine("####################");
            Console.WriteLine();


        }
    }
}
