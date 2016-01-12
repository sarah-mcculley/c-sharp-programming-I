/*
 * Author: Sarah McCulley
 * Purpose: Class Prices accepts user input for 20 prices, finds their sum and average, gives a list of those less than five and those greater than the average.
 */

using System;

namespace PricesProject
{
    class Prices
    {
        public static void Main(string[] args)
        {
            decimal[] prices = FillArray();
            decimal sum = GetSum(prices);
            decimal[] numbersLessThanFive = GetPricesUnderFive(prices);
            decimal average = GetAverage(sum, prices);
            decimal[] numbersGreaterThanAverage = GetPricesGreaterThanAverage(prices, average);
            Display(sum, numbersLessThanFive, average, numbersGreaterThanAverage);

        }

        private static decimal[] FillArray()
        {
            const int NUMBER_OF_PRICES = 20;
            decimal[] prices = new decimal[NUMBER_OF_PRICES];
            int counter = 0;
            Console.WriteLine("In any order, enter {0} price values. ", NUMBER_OF_PRICES);

            while(counter < NUMBER_OF_PRICES ) 
            {
                Console.Write("Enter price {0}: ", counter + 1);
                prices[counter] = Convert.ToDecimal(Console.ReadLine());
                counter = counter + 1;
            }
            return prices;
        }
        

        private static decimal GetSum(decimal[] prices)
        {
            decimal sum = 0;
            int i;

            for (i = 0; i < prices.Length; i++)
            {
                sum += prices[i];
            }
            return sum;
        }

        private static decimal[] GetPricesUnderFive(decimal[] prices)
        {
            Array.Sort(prices);
            const int TEST_NUMBER = 5;
            int numberLessThanFive = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < TEST_NUMBER) 
                {
                    numberLessThanFive = numberLessThanFive + 1;
                }
            }

            decimal[] numbersLessThanFive = new decimal[numberLessThanFive];
            int counter = 0;   
            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < TEST_NUMBER) 
                {
                    numbersLessThanFive[counter] = prices[i];
                    counter = counter + 1;
                }
            }
            return numbersLessThanFive;
        }

        private static decimal GetAverage(decimal sum, decimal[] prices)
        {
            decimal average = 0;
            average = sum/prices.Length;
            return average;
        }


        private static decimal[] GetPricesGreaterThanAverage(decimal[] prices, decimal average)
        {
            Array.Sort(prices);
            int numberGreaterThanAverage = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] > average)
                {
                    numberGreaterThanAverage = numberGreaterThanAverage + 1;
                }
            }

            decimal[] numbersGreaterThanAverage = new decimal[numberGreaterThanAverage];
            int counter = 0;
            for(int i = 0; i < prices.Length; i++)
            { 
                if(prices[i] > average)
                {
                    numbersGreaterThanAverage[counter] = prices[i];
                    counter = counter + 1;
                }
            }
            return numbersGreaterThanAverage;
        }

        private static void Display(decimal sum, decimal[] numbersLessThanFive, decimal average, decimal[] numbersGreaterThanAverage)
        {
            Console.WriteLine();
            Console.WriteLine("The sum of the values is: {0}.", sum.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("List of prices less than $5.00.");

            for (int i = 0; i < numbersLessThanFive.Length; i++)
            {
                Console.WriteLine(numbersLessThanFive[i].ToString("C"));
            }
            Console.WriteLine();
            Console.WriteLine("The price average is: {0}.", average.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("List of prices higher than the average:");

            for (int i = 0; i < numbersGreaterThanAverage.Length; i ++)
            {
                Console.WriteLine(numbersGreaterThanAverage[i].ToString("C"));
            }
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();

        }
    }
}
