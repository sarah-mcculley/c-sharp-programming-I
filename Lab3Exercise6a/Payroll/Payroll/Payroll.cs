/*
 * Author: Sarah McCulley
 * Purpose: Class Payroll calculates gross pay, withholding tax, and net pay based on pay rate and number of hours worked.
 */

using System;

namespace PayrollProject
{
    class Payroll
    {
        static void Main(string[] args)
        {
            const decimal SMALL_TAX_RATE = .1m;
            const decimal LARGE_TAX_RATE = .12m;
            decimal payRate;
            decimal hours;
            decimal grossPay;
            decimal withholdingTax;
            decimal netPay;

            Console.WriteLine("*** Payroll Office ***");
            Console.WriteLine();
            Console.Write("Enter hourly pay rate: ");
            payRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter hours worked: ");
            hours = Convert.ToDecimal(Console.ReadLine());

            grossPay = payRate * hours;

            if (grossPay <= 300)
            {
                withholdingTax = SMALL_TAX_RATE * grossPay;
            }
            else
            {
                withholdingTax = LARGE_TAX_RATE * grossPay;
            }

            netPay = grossPay - withholdingTax;

            Console.WriteLine();
            Console.WriteLine("{0, -22} {1, 10}", "Gross pay:", grossPay.ToString("C"));
            Console.WriteLine("{0, -22} {1, 10}", "Tax withholding:", withholdingTax.ToString("C"));
            Console.WriteLine("{0, -22} {1, 10}", "Net pay:", netPay.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();

        }
    }
}
