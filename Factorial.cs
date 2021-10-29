using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_Assignments
{
    class Factorial
    {
        public static void CalculateFactorial()
        {
            int product = 1;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                product = product * i;
            }
            Console.WriteLine("Factorial of " + number + " is" + product);
        }
    }
}
