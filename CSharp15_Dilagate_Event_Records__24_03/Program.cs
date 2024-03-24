namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class StringExtensions
    {
        public static int LengthOfLastWord(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            
            if (words.Length == 0)
                return 0;

            
            return words[words.Length - 1].Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string testString = "This is a test string for counting the length of the last word.";

            int lengthOfLastWord = testString.LengthOfLastWord();
            Console.WriteLine($"The length of the last word in the string is: {lengthOfLastWord}");
        }
    }
}
