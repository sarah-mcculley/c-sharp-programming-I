/*
 * Authors: Stephanie Vrona, Sarah Mcculley, Jesse Remnant, Mark Woods, Tyler Heizman
 * Date: 1/29/2015
 * Purpose: This program asks for a number and displays dashes based on the number input.
*/

using System;

    class InClassLabChapt5
    {
        enum CountDash
        {
            DASH = 1
        }

        public static void Main()
        {
            int number;
            int lineDashes;
            int totalLines;
            int currentLine;
            int dashes;
            Console.WriteLine("To terminate this program, enter a negative value for the highest point.");
            Console.WriteLine();
            Console.Write("Enter the value of the highest point: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number >= 0)
            {
                totalLines = 2 * number - 1;
                for (currentLine = 1; currentLine <= totalLines; ++currentLine)
                {
                    if (currentLine <= number)
                    {
                        lineDashes = currentLine;
                    }
                    else
                    {
                        lineDashes =  2 * number - currentLine;
                    }

                    for (dashes = 1; dashes <= lineDashes; ++dashes)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }

                for (currentLine = 1; currentLine <= number; ++currentLine)
                {
                    for (dashes = 1; dashes <= currentLine; ++dashes)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
                for (currentLine = number - 1; currentLine >= 1; --currentLine)
                {
                    for (dashes = 1; dashes <= currentLine; ++dashes)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }

                Console.Write("Enter the value of the highest point: ");
                number = Convert.ToInt32(Console.ReadLine());    
            }
        }
    }
