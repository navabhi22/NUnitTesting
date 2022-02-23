using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class TempConversion
    {
        /// <summary>
        /// Temperature conversion
        /// Celsius to Fahrenheit and Fahrenheit to Celsiua
        /// </summary>
        public static void TemperatureConversion()
        {
            Console.WriteLine("Press 1 to Convert From Celsius to Fahrenheit");
            Console.WriteLine("Press 2 to Convert From Fahrenheit to Celsius");
            int Unit = Convert.ToInt32(Console.ReadLine());
            int temp;
            if (Unit == 1)
            {
                Console.WriteLine("Enter the temperature in Celsius");
                temp = Convert.ToInt32(Console.ReadLine());
                temp = (temp * 9 / 5) + 32;
                Console.WriteLine("The temp is {0} °F ", temp);
            }
            
            else if (Unit == 2)
            {
                Console.WriteLine("Enter the temperature in Fahrenheit");
                temp = Convert.ToInt32(Console.ReadLine());
                temp = (temp - 32) * 5 / 9;
                Console.WriteLine("The temp is {0} °C ", temp);
            }
            else
            {
                Console.WriteLine("Choose a valid Conversion");
            }
        }

        
    }
}
