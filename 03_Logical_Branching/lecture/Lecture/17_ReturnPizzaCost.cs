using System;

namespace Lecture
{
    public partial class LectureExample
    {
        private const double Small = 8.99;
        private const double Medium = 9.99;
        private const double Large = 10.99;
        private const double Under_3_Toppings = 1.00;
        private const double Over_3_Toppings = 0.75;
        public double ReturnPizzaCost(char size, int numberOfToppings)
        {
            // You can declare variables in methods. Declare a variable to hold the cost of the pizza.
            // Set its value based on the size. Then add the cost for the toppings and return the total cost
            
            double result = 0.0;

            if (numberOfToppings <= 3)
            {
                result = numberOfToppings * Under_3_Toppings;
            }
            else
            {
                result = numberOfToppings * Over_3_Toppings;
            }
            
            if (size == 's')
            {
                result += Small;
            }
            else if (size == 'm')
            {
                result += Medium;
            }
            else //large 
            {
                result += Large;
            }

            return result;
        }
    }
}
