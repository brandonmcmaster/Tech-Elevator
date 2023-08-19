using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter you name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Your name is "+ name);

            Console.Write("Please enter your favorite number: ");

            string numberAsString = Console.ReadLine();

            int number = int.Parse(numberAsString);

            Console.WriteLine("Your number is:" + number);

            Console.WriteLine("Your number plus 100 is: " + (number + 100));


            Console.WriteLine("Please enter some names, seperated by a space: ");

            string userEnteredNames = Console.ReadLine();

            string[] names = userEnteredNames.Split(" ");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("At index " + i + ", the value is " + names[i]);
            }



            Console.WriteLine("Please enter some numbers, seperated by a space: ");

            string userEnteredNumbers = Console.ReadLine();

            string[] numbers = userEnteredNumbers.Split(" ");

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int value = int.Parse(numbers[i]);

                sum = sum + value;            
            }

            Console.WriteLine("The total of the nubmers is: " + sum);


            string userName = "";

            while (userName != "John")
            {
                Console.WriteLine("That's not the right name. Try again.");
                userName = Console.ReadLine();
            }





        }
    }
}
