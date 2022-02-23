using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class FewerNotes
    {
        /// <summary>
        /// Calculate the minimum amount of notes require to return
        /// </summary>
        /// <param name="ReturnAmount">The return amount.</param>
        /// <returns></returns>
           public static int MinimumNotes(int ReturnAmount)
        {
            int ThousandsNote = ReturnAmount / 1000;
            Console.WriteLine("No. of Thousands Rupees notes = " + ThousandsNote);
            int balance = ReturnAmount % 1000;
            int FiveHundredsNote = balance / 500;
            Console.WriteLine("No. of FiveHundred Rupees notes = " + FiveHundredsNote);
            balance = balance % 500;
            int HundredsNote = balance / 100;
            Console.WriteLine("No. of Hundred Rupees notes = " + HundredsNote);
            balance = balance % 100;
            int FiftysNote = balance / 50;
            Console.WriteLine("No. of Fifty Rupees notes = " + FiftysNote);
            balance = balance % 50;
            int TensNote = balance / 10;
            Console.WriteLine("No. of Ten Rupees notes = " + TensNote);
            balance = balance % 10;
            int FivesNote = balance / 5;
            Console.WriteLine("No. of Five Rupees notes = " + FivesNote);
            balance = balance % 5;
            int TwosNote = balance / 2;
            Console.WriteLine("No. of Two Rupees notes = " + TwosNote);
            balance = balance % 2;
            int OnesNote = balance;
            Console.WriteLine("No. of One Rupees notes = " + OnesNote);
            int MinNotes = ThousandsNote +FiveHundredsNote+ HundredsNote +FiftysNote+ TensNote + FivesNote + TwosNote + OnesNote;


            return MinNotes;
        }

    }
}
