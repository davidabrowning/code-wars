namespace WeirdStringCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Weird string case";
            Console.WriteLine($"{s} => {Kata.ToWeirdCase(s)}");
        }
    }

    public class Kata
    {
        public static string ToWeirdCase(string s)
        {
            string result = "";
            int letterCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    letterCounter = 0;
                    result += s[i];
                }
                else if (letterCounter % 2 == 0)
                {
                    letterCounter++;
                    result += s[i].ToString().ToUpper();
                }
                else
                {
                    letterCounter++;
                    result += s[i].ToString().ToLower();
                }
            }
            return result;
        }
    }
}
