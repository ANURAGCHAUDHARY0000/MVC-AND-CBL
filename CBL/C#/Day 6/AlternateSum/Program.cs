namespace AlternateSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 60, 60, 45, 70 };
            PrintAlternateSum(AlternatingSum(numbers));
        }

        private static int [] AlternatingSum(int[] num)
        {
            HashSet<int> result = new HashSet<int>();   
            int sum_even = 0;
            int sum_odd = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sum_even = sum_even + num[i];
                }
                else 
                    sum_odd = sum_odd + num[i];

            }
            result.Add(sum_even);
            result.Add(sum_odd);
            return result.ToArray();   
            
        }

        public static void PrintAlternateSum(int[] number)
        {
            foreach(int num in number)
            {
                Console.WriteLine(num);
            }
           
        }
    }
}
