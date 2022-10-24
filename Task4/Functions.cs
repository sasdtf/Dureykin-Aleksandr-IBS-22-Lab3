using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    internal class Functions
    {
        public static string ReturningWithReg(string str)
        {
            string pattern = (@"\<(.*?)\>");
            string rezult1 = Regex.Replace(str, pattern, "_");
            return rezult1;
        }
        public static string ReturningWithoutReg(string str)
        {
            int startIndex = 0;
            int begining = 0;
            int ending = 0;
            var sb = new StringBuilder();
            while (str.IndexOf('<', startIndex) != -1)
            {
                ending = str.IndexOf('<', startIndex);
                sb.Append(str.Substring(begining, ending - begining));
                sb.Append('_');
                begining = str.IndexOf('>', startIndex) + 1;
                startIndex = begining;

            }
            sb.Append(str.Substring(begining, str.Length - begining));
            string rezult2 = sb.ToString();
            return rezult2;
        }
    }
}
