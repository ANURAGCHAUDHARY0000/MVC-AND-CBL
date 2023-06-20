namespace CommonCharCountDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = "aabcc";
            String s2 = "adcaa";
            PrintResult(CommonCharacterCount(s1, s2));
        }

        private static int CommonCharacterCount(string s1, string s2)
        {
            Dictionary<Char, int> charCount = new Dictionary<Char, int>();

            foreach(char c in s1)
            {
                if(charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;

            }
            int commonChars = 0;

            foreach (char c in s2)
            {
                if (charCount.ContainsKey(c)  && charCount[c] > 0)

                {
                    commonChars++;
                    charCount[c]--;
                    
                }

            }

            return commonChars;

        }


        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }

    }
}