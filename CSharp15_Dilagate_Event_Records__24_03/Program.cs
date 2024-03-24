namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class StringExtensions
    {
        public static int CountConsonants(this string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c) && !"aeiouAEIOU".Contains(c))
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
            int consonantCount = text.CountConsonants();
            Console.WriteLine($"The number of consonants in the text is: {consonantCount}");
        }
    }
}
