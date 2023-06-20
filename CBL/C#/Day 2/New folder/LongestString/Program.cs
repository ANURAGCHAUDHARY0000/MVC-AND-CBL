namespace LongestString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] s1 = new string[] { "abc", "ab", "pqr", "lmn", "lm" };
            printLongeststring(FindLongestString(s1));
        }

        private static string []  FindLongestString(string[] s1)
        {
            List<string> list = new List<string>();
            int maxlength = 0;
            for(int i  = 0; i<s1.Length; i++)
            {
                if(maxlength < s1[i].Length)
                  maxlength = s1[i].Length;
            }
            foreach(string s2 in s1)
            {
                if(maxlength == s2.Length)
                {
                    list.Add(s2);
                }
            }
            return list.ToArray();
            
        }

        public static void printLongeststring(string[] str)
        {
            foreach(string s2 in str)
            {
                Console.WriteLine(s2);
            }
        }
    }
}