namespace FirstNonRepeatingCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abacabad";
            string str4 = "aa";
            string str2 = "abacabaabacaba";
            PrintResult(FindFirstNonRepeatingCharacter(str4));
            PrintResult(FindFirstNonRepeatingCharacter(str2));
        }

        private static void PrintResult(char v)
        { 
            Console.WriteLine(v);
        }

        
        private static char FindFirstNonRepeatingCharacter(string str1)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                char c = str1[i];
                if (str1.IndexOf(c) == str1.LastIndexOf(c))
                {
                    return c;
                }
            }
            return '_';
        }

    }
}