using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChar;
            double lengthInput;
            double resultLength = 0;

            Console.WriteLine("Is the unit of length being converted in meters or feet? \r\nPlease indicate by typing either M for meters or F for feet.");
            userChar = Console.ReadLine().ToUpper();

            Console.WriteLine("What is the length?");
            lengthInput = double.Parse(Console.ReadLine());

           
            
            if (userChar == "F")
            {
                resultLength = lengthInput *0.3048;
            }
            else if (userChar == "M")
            {
                resultLength = lengthInput * 3.2808399;
            }
            else
            {
            
                
                Console.WriteLine("That is not a valid input");
            }
            Console.WriteLine("The converted length is " + resultLength +  "\r\nYour original length was " + lengthInput);
        }
    }
}
