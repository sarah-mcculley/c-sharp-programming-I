/*
 * Author: Sarah McCulley
 * Purpose: Class EggsInteractive lets a user input eggs per chicken and outputs the dozens and eggs.
 */

using System;

namespace EggProject
{
    public class EggsInteractive
    {
        public static void Main(string[] args)
        {
            const int DOZEN = 12;
            int chicken1, chicken2, chicken3, chicken4;
            int sumEggs;
            int dozensEggs;
            int leftoverEggs;

            Console.WriteLine("Enter the number of eggs for chicken one.");
            chicken1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of eggs for chicken two.");
            chicken2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of eggs for chicken three.");
            chicken3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of eggs for chicken four.");
            chicken4 = Convert.ToInt32(Console.ReadLine());
            sumEggs = chicken1 + chicken2 + chicken3 + chicken4;
            dozensEggs = sumEggs / DOZEN;
            leftoverEggs = sumEggs % DOZEN;
            Console.WriteLine("There are {0} dozen and {1} eggs.", dozensEggs, leftoverEggs);
            Console.Read();







        }
    }
}
