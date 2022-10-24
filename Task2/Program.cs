namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "А роза упала на лапу Азора";
            
            if (Functions.CheckingPolindrom(text))
            {
                Console.WriteLine("палиндромом");
            }
            else
            {
                Console.WriteLine("не палиндромом");
            }
        }
    }
}