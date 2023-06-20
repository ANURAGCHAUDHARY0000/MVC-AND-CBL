namespace CheckEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 642386;
            PrintResult(CheckEvenDigits(number));
            PrintResult(CheckEvenDigits(number));

        }

        private static void PrintResult(bool v)
        {
            Console.WriteLine(v);
        }

        private static bool CheckEvenDigits(int number)
        {
            string checkNumber = number.ToString();
            int count = 0;
            for(int i = 0; i < checkNumber.Length; i++)
            {
                if (int.Parse(checkNumber[i].ToString()) % 2 == 0)
                    count++;
            }

            return count == checkNumber.Length;
        }

        private static bool CheckEvenDigitsWithoutString(int number)
        {
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                if (digit % 2 != 0)
                    return false;
                number /= 10;
            }
            return true;
        }
    }
}