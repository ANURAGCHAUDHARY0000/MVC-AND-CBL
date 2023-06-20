namespace FindFirstDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphaNum = "q30s3s";
            PrintResult(FirstDisgit(alphaNum));
        }

        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }

        private static int FirstDisgit(string alphaNum)
        {
            char[] chars = alphaNum.ToCharArray();
            int result = 0;
            for(int i = 0; i < alphaNum.Length; i++)
            {
                if(chars[i] >= '0'  && chars[i] <= '9')
                {
                    result = chars[i] - '0';
                    break;
                }
            }
            return result;
        }
    }
}