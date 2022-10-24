using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    internal class Functions
    {
        public static void PrintingDates(string str)
        {
            string pattern = @"\s?(?<day>[12][0-9]|[0][1-9]|[3][01])\-(?<month>[0][1-9]|[1][0-2])\-" +
                @"\s?(?<year>[0-9][0-9][0-9][0-9])\s?";
            Regex regex = new Regex(pattern);
            foreach (Match match in regex.Matches(str))
            {
                Console.WriteLine($"Дата {match.Value} где день - {match.Groups["day"]}, месяц - {match.Groups["month"]}, год - {match.Groups["year"]}");
            }
        }
    }
}
