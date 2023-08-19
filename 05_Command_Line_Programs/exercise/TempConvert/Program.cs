using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            string userChar;
            double userTemp;
            double resultTemp = 0;

            Console.WriteLine( "Is the temperature in C or F?");
            userChar = Console.ReadLine().ToUpper();

            Console.WriteLine( "What is the temperature?");
            userTemp = double.Parse(Console.ReadLine());

            if (userChar == "C")
            {
                resultTemp = userTemp * 9 / 5 + 32;
            }

            else if (userChar == "F") 
            {
                resultTemp = (userTemp - 32) * 5 / 9;
            
            }else 
            {
                Console.WriteLine( "That is not a valid input");
            }
            Console.WriteLine( "The converted temperature is " + resultTemp + "\r\nYour original temperature was " + userTemp);
        }
    }
}
