/*
 * Author: Sarah McCulley
 * Purpose: The class Sum lets the user enter any number of integer values and displays the number of values entered and their sum.
 */

using System;

namespace SumProject
{
    public class Sum
    {
        public static void Main(string[] args)
        {
            const int END = 999;
            int number;
            int sum = 0;
            int count = 0;

            Console.WriteLine("*** Addition of Integer Numbers ***");
            Console.WriteLine();
            Console.WriteLine("To stop this program, enter the value 999.");
            Console.Write("Enter an integer number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while(number != END)
            {
                count = count +1;
                sum = sum + number;
                Console.Write("Enter an integer number: "); 
                number = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("The sum of the numbers is: {0}", sum.ToString());
            Console.WriteLine("The number count is: {0}", count.ToString());
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();

        }
    }
}
