using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Functions
    {
        public static double AverageLength(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            double averageLength  = 0;
            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }
            averageLength = sum / words.Length;
            return averageLength;
        }
    }
}
