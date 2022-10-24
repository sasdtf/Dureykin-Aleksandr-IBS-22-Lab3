using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text= @"2008 год наступит 01-01-2058 
                           и закончится 31-12-2098";
            Regex regex=Functions.Dates(text);
            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine($"Дата {match.Value} где день - {match.Groups["day"]}, месяц - {match.Groups["month"]}, год - {match.Groups["year"]}");
            }

        }
    }
}