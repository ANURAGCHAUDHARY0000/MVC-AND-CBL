namespace MissingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefg";
            string st1 = "abcdefghijklmnopqrstuvwxyz";
            PrintResult(FindMissingCharacters(st1));
            PrintResult(FindMissingCharacters(s));
        }

        private static void PrintResult(char v)
        {
            Console.WriteLine(v);
        }

        private static char FindMissingCharacters(string s)
        {
            
            char result = '_' ;
            if (s[0] != 'a')
            {
                return result ;
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (s.ToLower().IndexOf(c) == -1)
                {
                    result =  c;
                    break;
                }
            }

            return result;
        }
    }
}