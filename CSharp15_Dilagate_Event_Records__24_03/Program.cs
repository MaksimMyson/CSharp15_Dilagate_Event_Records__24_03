namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class IntExtensions
    {
        public static bool IsFibonacci(this int number)
        {
            if (number < 0)
                return false;

            int a = 0, b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int testNumber = 13;

            if (testNumber.IsFibonacci())
            {
                Console.WriteLine($"{testNumber} is a Fibonacci number.");
            }
            else
            {
                Console.WriteLine($"{testNumber} is not a Fibonacci number.");
            }
        }
    }
}
