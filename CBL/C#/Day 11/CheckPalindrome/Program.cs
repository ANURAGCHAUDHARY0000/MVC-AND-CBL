using System;
using System.Linq;

namespace CheckPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string :");
            String s1 = "anurag";
            PrintResult(IsCaseInsensitivePalindrome(s1.ToLower()));
            PrintResult(IsCaseSensitivePalindrome(s1));
        }

        private static bool IsCaseInsensitivePalindrome(string s1)
        {
            
            string reverse = string.Empty;
            Char[] charArray  = s1.ToCharArray();
            for(int i = charArray.Length -1; i > -1; i--)
            {
                reverse = reverse + charArray[i];
            }


            return s1.Equals(reverse);
        }

        private static bool IsCaseSensitivePalindrome(string s1)
        {
            return s1.SequenceEqual(s1.Reverse());
        }

        private static void PrintResult(bool v)
        {
            Console.WriteLine(v);
        }
    }


}