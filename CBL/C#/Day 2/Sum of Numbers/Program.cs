namespace LongestString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            printSum(Add(10, 20, 30, 40, 50));
            printSum(Add(10));
        }


        private static int Add(params int[] listofnumbers)
        {
            int total = 0;
            foreach (int number in listofnumbers)
            {
                //total = total + number;
                total += number;
            }
            return total;
        }


        private static void printSum(int sum)
        {
            Console.WriteLine("Total sum is : "+ sum);
        }


    }
}