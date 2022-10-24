using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Functions
    {
        public static bool CheckingPolindrom(string text)
        {
            char[] charText = text.ToUpper().ToCharArray();
            var palindrome = new StringBuilder();
            for (int i = 0; i < charText.Length; i++)
            {
                if (char.IsLetter(charText[i]))
                {
                    palindrome.Append(charText[i]);
                }
            };
            char[] finalСharText = palindrome.ToString().ToCharArray();
            Array.Reverse(finalСharText);
            string reversPalindrome = new string(finalСharText);
            if (palindrome.ToString() == reversPalindrome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
