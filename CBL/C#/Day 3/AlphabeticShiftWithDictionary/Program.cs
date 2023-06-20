namespace AlphabeticShiftWithDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Word : ");
            string word = Console.ReadLine().ToLower();
            PrintDetails(AlphabeticShift(word));
        }

        private static string AlphabeticShift(string word)
        {
            Dictionary<char, char> charMap = new Dictionary<char, char> {
            {'a', 'b'}, {'b', 'c'}, {'c', 'd'}, {'d', 'e'},
            {'e', 'f'}, {'f', 'g'}, {'g', 'h'}, {'h', 'i'},
            {'i', 'j'}, {'j', 'k'}, {'k', 'l'}, {'l', 'm'},
            {'m', 'n'}, {'n', 'o'}, {'o', 'p'}, {'p', 'q'},
            {'q', 'r'}, {'r', 's'}, {'s', 't'}, {'t', 'u'},
            {'u', 'v'}, {'v', 'w'}, {'w', 'x'}, {'x', 'y'},
            {'y', 'z'}, {'z', 'a'}
            };

            string shifted_word = "";
            foreach (char c in word)
            {
                if (charMap.ContainsKey(c))
                {
                    shifted_word += charMap[c];
                }
            }
            return shifted_word;

        }


        private static void PrintDetails(string word)
        {
            Console.WriteLine(word);
        }
    }
}