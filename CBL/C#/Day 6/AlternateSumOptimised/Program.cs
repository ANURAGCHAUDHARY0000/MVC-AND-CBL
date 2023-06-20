namespace AlternateSumOptimised
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = { 50, 60, 60, 45, 70 };
            int[] numbers = { 50, 60 };
            PrintSum(AlternateSum(numbers));
        }

        private static int [] AlternateSum(int[] numbers)
        {
            int[] sum = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                sum[i%2] = sum[i%2] + numbers[i];

            }
            return sum;
        }
        
        public static void PrintSum(int[] num)
        {
            foreach (int i in num)
                Console.WriteLine(i);
        }
    }
}