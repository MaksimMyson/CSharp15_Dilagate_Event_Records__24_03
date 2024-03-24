namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string testString = "This is a test string for word counting.";

            int wordCount = testString.WordCount();
            Console.WriteLine($"The number of words in the string is: {wordCount}");
        }
    }
}
