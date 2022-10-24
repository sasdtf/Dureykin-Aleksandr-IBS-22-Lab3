using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите адрес электронной почты");
           // string email = Console.ReadLine();
            string email = "p_ivanov@mail.rol.ru";
            Console.WriteLine(Functions.CheckingEmailOrNo(email));
            Console.ReadKey();

        }
    }
}