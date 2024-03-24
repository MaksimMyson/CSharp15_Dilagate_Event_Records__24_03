namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class StringExtensions
    {
        public static int CountVowels(this string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, how are you?";
            int vowelCount = text.CountVowels();
            Console.WriteLine($"The number of vowels in the text is: {vowelCount}");
        }
    }
}
