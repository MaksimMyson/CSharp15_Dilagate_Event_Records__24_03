namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            if (array == null || predicate == null)
                throw new ArgumentNullException();

            int[] filteredArray = new int[array.Length];
            int count = 0;

            foreach (int element in array)
            {
                if (predicate(element))
                {
                    filteredArray[count] = element;
                    count++;
                }
            }

            Array.Resize(ref filteredArray, count);
            return filteredArray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            
            int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            int[] oddNumbers = numbers.Filter(x => x % 2 != 0);
            Console.WriteLine("Odd numbers:");
            foreach (int num in oddNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
