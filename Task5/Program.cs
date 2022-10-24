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
            Functions.PrintingDates(text);
        }
    }
}