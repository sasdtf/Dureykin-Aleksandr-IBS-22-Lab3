using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class Functions
    {
        public static bool CheckingEmailOrNo(string email)
        {
            string pattern= @"^[a-z0-9](?:[a-z0-9\._\-]*[a-z0-9])?\@" + @"(?:(?:[a-z0-9][a-z0-9_\-]*[a-z0-9]|[a-z0-9])\.)+(?:[a-z]{2,6})$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}

