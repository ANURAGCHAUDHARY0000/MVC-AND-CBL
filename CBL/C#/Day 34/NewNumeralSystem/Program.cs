namespace NewNumeralSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  s = "G";
            PrintResult(NewNumeralSystem(s));
        }

        private static void PrintResult(List<string> list)
        {
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }

        private static List<string> NewNumeralSystem(string str)
        {
            int num = (int)str[0] - 65; 
            List<string> result = new List<string>();

            for (int i = 0; i <= num / 2; i++)
            {
                int j = num - i;
                char first = (char)(i + 65);
                char second = (char)(j + 65);
                result.Add($"{first}+{second}");
            }

            return result;

        }
    }
}