namespace StopSpinningMyWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = {
                "Hey fellow warriors",
                "This is a test",
                "This is another test" };
            foreach (string sentence in sentences)
            {
                string spunSentence = SpinWords(sentence);
                Console.WriteLine($"{sentence} --> {spunSentence}");
            }
        }

        public static string SpinWords(string sentence)
        {
            string spunSentence = "";
            string[] words = sentence.Split(" ");
            foreach (string word in words)
            {
                spunSentence += SpinWord(word);
                spunSentence += " ";
            }
            return spunSentence.Trim();
        }

        private static string SpinWord(string word)
        {
            // If word is less than 5 characters, do not reverse
            if (word.Length < 5)
            {
                return word;
            }

            // Otherwise, reverse the word
            string spunWord = "";
            char[] letters = word.ToCharArray();
            Array.Reverse(letters);
            foreach (char letter in letters)
            {
                spunWord += letter;
            }
            return spunWord;
        }
    }
}
