namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class StringExtensions
    {
        public static int CountSentences(this string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == '.' || c == '!' || c == '?')
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
            string text = "Hello! How are you? I hope you're doing well.";
            int sentenceCount = text.CountSentences();
            Console.WriteLine($"The number of sentences in the text is: {sentenceCount}");
        }
    }
}
