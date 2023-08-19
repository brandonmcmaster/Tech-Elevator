using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter your name: ");

          string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine(name + " what is your favorite number? ");

            string numberAsString = Console.ReadLine();

            int number = int.Parse(numberAsString);

            Console.WriteLine( "Your favorite number is: " + number);

            Console.WriteLine( "Your number plus 100 is: " + (number + 100));

            Console.WriteLine( "Please enter some numbers, separated by a space: ");

            string userEnteredNumbers = Console.ReadLine();

            string[] numbers = userEnteredNumbers.Split(" ");

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int value = int.Parse(numbers[i]);
               
                sum = sum + value;

            }

            Console.WriteLine("The total of the numbers is: " + sum);

            string userName = "";

            while (userName != "John") 
            {
                Console.WriteLine( "That's not the right name. Try again.");
                userName = Console.ReadLine();
            }
            Console.WriteLine( "Your name is " + userName + "!");
        }
    }
}
