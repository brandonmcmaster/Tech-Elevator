using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by a space");

            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");

            foreach (string inputNumber in numbers)
            {
                if (int.TryParse(inputNumber, out int decimalNumber))
                {
                    string binaryNumber = Convert.ToString(decimalNumber, 2);
                    Console.WriteLine($"{inputNumber} in binary is {binaryNumber}");
                }
                else
                {
                    Console.WriteLine($"{inputNumber} is not a valid entry");
                }
                }
            }
        }
    }


