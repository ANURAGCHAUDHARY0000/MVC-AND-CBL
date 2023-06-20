namespace DigitDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = 12345;
            PrintResult(CheckDigitDegree(numbers));
        
        }

        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }

        private static int CheckDigitDegree(int numbers)
        {
            if (numbers <= 9)
            {
                return 0;
            }

            int sum = 0;
            while (numbers > 0)
            {
                int remainder = numbers % 10;
                sum += remainder;
                numbers /= 10;
            }

            if (sum <= 9)
            {
                return 1;
            }

            return 1 + CheckDigitDegree(sum);
        }
    }
}
