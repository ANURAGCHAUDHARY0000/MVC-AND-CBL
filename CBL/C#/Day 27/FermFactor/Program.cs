namespace FermFactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 21;
            PrintResult(FermFactor(number));
                
         }

        private static void PrintResult(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
                Console.WriteLine(ints[i]);
        }

        private static int [] FermFactor(int number)
        {
            
            List<int> list = new List<int>();
            
            for (int i = 1; i < number/2 ; i++)
            {
                for (int j = i; j < number/2; j++)
                {
                    if ((j + 1) * (j + 1) - (i) * (i) == number)
                    {
                        list.Add(j+1);
                        list.Add(i);
                        break;

                    }
                }
                if (list.Count == 2)
                    break;

            }

            return list.ToArray();
            
            
        }
    }
}