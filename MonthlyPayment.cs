using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {
        /// <summary>
        /// Calculates the monthly payment.
        /// </summary>
        public static void CalculateMonthlyPayment()
        {
            Console.WriteLine("Enter the Princeple Amount");
            int PrincipleAmt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time Period in Years");
            int Time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate");
            double Rate = Convert.ToDouble(Console.ReadLine());
            double r = Rate/12/100;
            int n = 12 * Time;
            double x = Math.Pow((1 + r), (n));
            double MonthlyPayment = (PrincipleAmt * r * x) / (x-1);  
            Console.WriteLine(MonthlyPayment);

        }
    }
}
