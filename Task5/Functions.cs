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
        public static Regex Dates(string str)
        {
            string pattern = @"(?<day>[12][0-9]|[0][1-9]|[3][01])\-(?<month>[0][1-9]|[1][0-2])\-" +
                @"(?<year>[0-9][0-9][0-9][0-9])\s?";
            Regex regex = new Regex(pattern);
            return regex;
        }
    }
}
