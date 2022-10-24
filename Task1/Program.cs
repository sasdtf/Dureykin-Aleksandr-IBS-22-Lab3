namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double averageLength;
            string text = "И я ем много   .  ,  .  , фффффффффффффффффффффффффффф";
            averageLength=Functions.AverageLength(text);
            Console.WriteLine(averageLength);
        }
    }
}
