using System;

namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programs of NUnit Testing");

            Console.WriteLine("enter the return amount");
            int Amt = Convert.ToInt32(Console.ReadLine());
            int MinNotes = FewerNotes.MinimumNotes(Amt);
            Console.WriteLine("The min no. of Notes required = " + MinNotes);

        }
    }
}