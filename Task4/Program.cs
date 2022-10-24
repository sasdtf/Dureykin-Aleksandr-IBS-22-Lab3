using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";
            string rezult1=Functions.ReturningWithReg(text);
            Console.WriteLine(rezult1);
            string rezult2 = Functions.ReturningWithoutReg(text);
            Console.WriteLine(rezult1);
        }
    }
}