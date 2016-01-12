using System;

namespace PayrollProject
{
    public class Payroll
    {
        public static void Main(string[] args)
        {
            const decimal FED_TAX = .15m;
            const decimal STATE_TAX = .05m;
            string name;
            string socialSecurityNum;
            decimal payRate;
            decimal hours;
            decimal grossPay;
            decimal fedWithholding;
            decimal stateWithholding;
            decimal netPay;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Social Security number: ");
            socialSecurityNum = Console.ReadLine();
            Console.Write("Hourly pay rate: ");
            payRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked: ");
            hours = Convert.ToDecimal(Console.ReadLine());

            grossPay = payRate * hours;
            fedWithholding = FED_TAX * grossPay;
            stateWithholding = STATE_TAX * grossPay;
            netPay = grossPay - (fedWithholding + stateWithholding);

            Console.WriteLine();
            Console.WriteLine("Payroll summary for: {0}", name);
            Console.WriteLine("SSN: {0}", socialSecurityNum);
            Console.WriteLine("You worked {0} hours at {1} per hour ", hours, payRate.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("{0, -22} {1, 15}", "Gross pay:", grossPay.ToString("C"));
            Console.WriteLine("{0, -22} {1, 15}", "Federal withholding:", fedWithholding.ToString("C"));
            Console.WriteLine("{0, -22} {1, 15}", "State withholding:", stateWithholding.ToString("C"));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("{0, -22} {1, 15}", "Net pay:", netPay.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();





        }
    }
}
