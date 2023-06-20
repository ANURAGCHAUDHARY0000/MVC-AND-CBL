namespace AlphabeticShift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            // string s1 = "crazy";
            PrintShiftedString(AlphabeticShift(word));
        }

        private static string AlphabeticShift(string s1)
        {
            string shiftedWord = "";
            foreach (char ch in s1)
            {
                char shiftChar;
                if(ch == 'z')
                {
                    shiftChar = 'a';
                }
                else if(ch == 'Z')
                {
                    shiftChar = 'A';
                }
                else
                {
                    shiftChar = (char)((int)ch + 1);
                }
                shiftedWord = shiftedWord + shiftChar;

             }
            return shiftedWord;
        }

        public static void PrintShiftedString(string s2)
        {
            Console.WriteLine(s2);
        }


    }
}