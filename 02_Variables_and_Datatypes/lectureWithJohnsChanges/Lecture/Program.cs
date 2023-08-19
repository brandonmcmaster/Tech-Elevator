using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            int numberOfExercises = 26;

            Console.WriteLine("Number of exercises: " + numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */

            double half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */

            string name;
            name = "TechElevator";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */

            int seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */

            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */

            double pi = 3.1416;

            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */

            string myName = "John";

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */

            int numberOfButtons = 6;

            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            int batteryPercentage = 96;

            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */

            int result = 121 - 27;

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double sum = 12.3 + 32.1;



            /*
            12. Create a string that holds your full name.
            */

            string fullName = "John \"The Boss\" Fulton ";

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello, " + fullName;

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */

            greeting = greeting + " Esquire";


            /*
            15. Now do the same as exercise 14, but use the += operator.
            */

            greeting += " Esquire";

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */

            string movieName = "Saw" + 2;
            Console.WriteLine(movieName);

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */

            movieName += 0;
            Console.WriteLine(movieName);

            /*
            18. What is 4.4 divided by 2.2?
            */

            Console.WriteLine( 4.4 / 2.2);

            /*
            19. What is 5.4 divided by 2?
            */

            Console.WriteLine(5.4 / 2);

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */

            Console.WriteLine(5 / (double) 2);

            /*
            21. What is 5.0 divided by 2?
            */

            /*
            22. What is 66.6 divided by 100? Is the answer you get right or wrong?
            */

            Console.WriteLine((double)66.6 / 100);

            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            Console.WriteLine(5%2);

            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together.
                What is the result?

            
            */
            int three = 3;
            int large = 1000000000;

            Console.WriteLine(three * (long)large);

            /*
            25. Create a variable that holds a boolean called isDoneWithExercises and
            set it to false.
            */

            /*
            26. Now set isDoneWithExercise to true.
            */

        }
    }
}
