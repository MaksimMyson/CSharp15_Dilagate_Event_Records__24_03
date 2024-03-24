namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = 17;

            if (numberToCheck.IsPrime())
            {
                Console.WriteLine($"{numberToCheck} is prime.");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is not prime.");
            }
        }
    }
}
