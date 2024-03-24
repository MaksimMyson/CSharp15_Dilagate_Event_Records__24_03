namespace CSharp15_Dilagate_Event_Records__24_03
{
    public static class StringExtensions
    {
        public static bool IsValidParentheses(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return true; 

            Dictionary<char, char> bracketsMap = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (bracketsMap.ContainsKey(c)) 
                {
                    stack.Push(c);
                }
                else if (bracketsMap.ContainsValue(c)) 
                {
                    if (stack.Count == 0 || bracketsMap[stack.Pop()] != c)
                    {
                        return false; 
                    }
                }
            }

            return stack.Count == 0; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string validString1 = "{}[]";
            string validString2 = "(())";
            string validString3 = "[{}]";
            string invalidString1 = "[}";
            string invalidString2 = "[[{]}]";

            Console.WriteLine($"Is '{validString1}' valid? {validString1.IsValidParentheses()}");
            Console.WriteLine($"Is '{validString2}' valid? {validString2.IsValidParentheses()}");
            Console.WriteLine($"Is '{validString3}' valid? {validString3.IsValidParentheses()}");
            Console.WriteLine($"Is '{invalidString1}' valid? {invalidString1.IsValidParentheses()}");
            Console.WriteLine($"Is '{invalidString2}' valid? {invalidString2.IsValidParentheses()}");
        }
    }
}
