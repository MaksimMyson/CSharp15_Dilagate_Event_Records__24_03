namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = 6;

            if (numberToCheck.IsEven())
            {
                Console.WriteLine($"{numberToCheck} is even.");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is not even.");
            }
        }
    }
}
