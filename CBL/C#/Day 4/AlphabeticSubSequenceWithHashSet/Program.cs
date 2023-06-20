namespace AlphabeticSubSequenceWithHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string : ");
            //string s1 = Console.ReadLine();
            string s1 = "xab";
            Print(AlphabeticSubSequenceWithHashSet(s1));
        }

        private static bool AlphabeticSubSequenceWithHashSet(string s2)
        {
            HashSet<char> myhash1 = new HashSet<char>();
            char ch = s2[0];
            for(int i = 1; i < s2.Length; i++)
            {
                if (ch < s2[i])
                {
                    ch = s2[i];
                    myhash1.Add(s2[i]);
                }
            }
            return myhash1.Count == s2.Length - 1;

        }

        public static void Print(bool result)
        {
            Console.WriteLine(result);
        }
    }
}