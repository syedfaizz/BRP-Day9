﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_Assignments
{
    class PrimeNumber
    {
        public static void CheckPrime()
        {
            int number;
            int divide = 0;
            Boolean number_is_prime = false;
            Console.Write("Enter the Number ");
            number = Convert.ToInt32(Console.ReadLine());
            divide = number / 2;
            for (int i = 2; i <= divide; i++)
            {
                if (number % i == 0)
                {
                    number_is_prime = false;

                }
                else
                {
                    number_is_prime = true;

                }
            }
            if (number_is_prime == true)
                Console.Write("Number is Prime.");
            else
                Console.Write("Number is not Prime.");
            Console.WriteLine(" ");
        }
    }
}
