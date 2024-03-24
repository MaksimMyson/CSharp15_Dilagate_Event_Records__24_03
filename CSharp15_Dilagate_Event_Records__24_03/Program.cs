namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class IntExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = 7;

            if (numberToCheck.IsOdd())
            {
                Console.WriteLine($"{numberToCheck} is odd.");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is not odd.");
            }
        }
    }
}
