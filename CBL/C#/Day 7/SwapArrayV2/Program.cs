namespace SwapArrayV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 ,4};
            int[] arr2 = { 2, 1, 4, 3};

            PrintResult(AreSimilarWithSwap(arr1, arr2));
        }

        private static bool AreSimilarWithSwap(int[] arr1, int[] arr2)
        {

            if (arr1 == null || arr2 == null || arr1.Length != arr2.Length)
            {
                return false;
            }

            int[] first_mismatch = new int[arr1.Length];
            int[] second_mismatch = new int[arr2.Length];
            int mismatch_count = 0; 

            for(int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    mismatch_count++;
                    first_mismatch[i] = arr1[i];
                    second_mismatch[i] = arr2[i];
                }
            }

            if (mismatch_count == 2)
            {
                Array.Reverse(second_mismatch);
                first_mismatch.SequenceEqual(second_mismatch);
                             
                return true;
            }
            return false;
          
        }

        private static void PrintResult(bool v)
        {
            Console.WriteLine(v);
        }
    }
}