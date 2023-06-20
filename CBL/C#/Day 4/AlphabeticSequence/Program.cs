namespace AlphabeticSequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
           // string s1 = Console.ReadLine();
            string s1 = "xab";
            PrintDetails(AlphabeticSubSequence(s1));
        }

        public static bool AlphabeticSubSequence(string s)
        {
            char ch = s[0];
            int count = 0;
            for(int i = 1; i < s.Length; i++)
            {
                if(ch < s[i])
                {
                    ch = s[i];
                    count++;
                }
            }
           return count == s.Length - 1;

        }

        public static void PrintDetails(bool v)
        {
            Console.WriteLine(v);
        }
    }
}