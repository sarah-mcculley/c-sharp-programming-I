/*
 * Author: Sarah McCulley
 * Purpose: Class Commission takes a whole dollar sales amount from a user and calulates the commission based on that amount.
 */

using System;

namespace CommissionProject
{
    class Commission
    {
        public static void Main(string[] args)
        {
            decimal salesAmount = GetSalesAmount(true);
            const int END = -1;
            while(salesAmount != END)
            {
                decimal commissionOnSales = CalculateCommission(salesAmount);
                salesAmount = GetSalesAmount(false);
            
            }
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate the program.");
            Console.Read();
            
        }

        private static decimal GetSalesAmount(bool displayHeader)
        {
            decimal salesAmount = 0;
            if (displayHeader)
            {
                Console.WriteLine("*** Commission Calculator ***");
                Console.WriteLine();
            }
            Console.WriteLine("Enter -1 to terminate the commission calculations.");
            Console.Write("Enter the daily sales (whole amount): ");
            salesAmount = Convert.ToDecimal(Console.ReadLine());

            return salesAmount;
        }

        private static decimal CalculateCommission(decimal salesAmount)
        {
            const int LEVEL_ONE_MINIMUM = 0;
            const int LEVEL_TWO_MINIMUM = 1000;
            const int LEVEL_THREE_MINIMUM = 3000;
            const decimal LEVEL_ONE_COMMISSION = .03m;
            const decimal LEVEL_TWO_COMMISSION = .04m;
            const decimal LEVEL_THREE_COMMISSION = .05m;
            decimal commission = 0m;
            decimal commissionOnSales = 0m;
            if(salesAmount >= LEVEL_ONE_MINIMUM && salesAmount < LEVEL_TWO_MINIMUM)
            {
                commission = LEVEL_ONE_COMMISSION;
            }
            else if(salesAmount >= LEVEL_TWO_MINIMUM && salesAmount < LEVEL_THREE_MINIMUM)
            {
                commission = LEVEL_TWO_COMMISSION;
            }
            else
            {
                commission = LEVEL_THREE_COMMISSION;
            }

            commissionOnSales = salesAmount * commission;

            Console.WriteLine();
            Console.WriteLine("   The commision on sales of {0} is {1}.", salesAmount.ToString("C"), commissionOnSales.ToString("C"));
            Console.WriteLine();
            return commissionOnSales;
        }
    }
}
