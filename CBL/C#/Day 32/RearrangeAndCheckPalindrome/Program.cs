namespace RearrangeAndCheckPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aabb";
            PrintResult(PalindromeRearranging(s1));
        }

        private static void PrintResult(bool v)
        {
            Console.WriteLine(v);
        }

        private static bool PalindromeRearranging(string s)
        {
            Dictionary<char, int> hmap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (hmap.ContainsKey(s[i]))
                    hmap[s[i]]++;
                else
                    hmap[s[i]] = 1;
            }
                     
            int oddCount = 0;

            foreach (KeyValuePair<char, int> kvp in hmap)
            {
                if (kvp.Value % 2 == 0)
                    continue;
                else
                    oddCount++;
            }

            if (s.Length % 2 == 0 && oddCount == 0)
                return true;
            if (s.Length % 2 != 0 && oddCount == 1)
                return true;
            else
                return false;
        }


    }
}