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
            char[] chars = str.ToCharArray();
            int amountIndexs = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '<')
                {
                    amountIndexs++;
                }
            }
            int[] indexs = new int[amountIndexs];
            int j = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '<')
                {
                    indexs[j] = i;
                    j++;
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            int firstSymbolIndex = 0;
            int lastSymbolIndex = 0;
            int countSymvols = 0;
            str = str.Replace("<", "_");
            for (int i = indexs.Length - 1; i >= 0; i--)
            {
                firstSymbolIndex = indexs[i];
                lastSymbolIndex = str.LastIndexOf(">");
                countSymvols = lastSymbolIndex - firstSymbolIndex;
                if(lastSymbolIndex< firstSymbolIndex)
                {
                    return str;
                }
                str = str.Remove(firstSymbolIndex + 1, countSymvols);
            }
            return str;

        }
    }
}
