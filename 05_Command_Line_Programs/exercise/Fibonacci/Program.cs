using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int fib1 = 0;
            int fib2 = 1;
            int nextNumber;

            Console.WriteLine( "Enter a number");
            number = int.Parse(Console.ReadLine());

            Console.Write($"Fibonacci sequence up to {number}: ");

            for (; fib1 <= number;)
            {
                Console.Write(fib1);

                if (fib1 != number)
                {
                    Console.Write(", ");
                }

                nextNumber = fib1 + fib2;
                fib1 = fib2;
                fib2 = nextNumber;
            }

        }
    }
}
