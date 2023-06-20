namespace CharacterParity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character : ");
            char ch = Convert.ToChar(Console.ReadLine());
            string result = CheckCharacterParity(ch);
            PrintResult(result);
        }

        private static string CheckCharacterParity(char ch)
        {
            if(ch >= '0'  && ch <= '9')
            {
                int num = ch - '0';
                if (num % 2 == 0)
                    return "even";
                else
                return "odd";
            }
            return "Not A Digit";

            // if(char.IsDigit(ch))
            // {
            //    int num = (int)ch;
            //    if (num % 2 == 0)
            //        return "even";
            //    else
            //        return "odd";
            // }
            //return "Not A Digit";
        }

        public static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

    }
}