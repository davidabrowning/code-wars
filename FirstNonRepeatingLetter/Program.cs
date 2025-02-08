namespace FirstNonRepeatingLetter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RunTests();
        }

        public static void RunTests()
        {
            RunTest("stress");
            RunTest("sTreSS");
            RunTest("aabbc");
            RunTest("abc");
            RunTest("aabbcc");
        }

        public static void RunTest(string s)
        {
            Console.WriteLine($"Input: {s} | Output: {FirstNonRepeatingLetter(s)}");
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            int[] letterCounts = new int[1000];
            foreach(char c in s)
            {
                char cLower = char.ToLower(c);
                letterCounts[cLower]++;
            }
            foreach(char c in s)
            {
                char cLower = char.ToLower(c);
                if (letterCounts[cLower] == 1)
                {
                    return c.ToString();
                }
            }
            return "";
        }

    }
}
