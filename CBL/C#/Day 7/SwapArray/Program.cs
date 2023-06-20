namespace SwapArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 4,3,2,1 };
            int[] arr2 = { 4,3,1,2 };
            PrintResult(AreSimilarWithSwap(arr1,arr2));

        }

      

        public static bool AreSimilarWithSwap(int[] arr1, int[] arr2)
        {
            int max_count = 0;
            int firstmismatch_index = -1;
            int secondmismatch_index = -1;  

            if(arr1 == null || arr2 == null || arr1.Length != arr2.Length)
            {
                return false;
            }

            for(int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    max_count++;
                    if(firstmismatch_index == -1)
                    {
                        firstmismatch_index = i;
                    }
                    else if(secondmismatch_index == -1)
                    {
                        secondmismatch_index = i;
                    }
                    else
                    {
                       return  false;
                    }
                }

            }

            if(max_count == 2)
            {
                if (arr1[firstmismatch_index] == arr2[secondmismatch_index] && arr2[firstmismatch_index] == arr1[secondmismatch_index])
                {
                    return true;
                }
            }

            return false;

            
        }

        private static void PrintResult(bool v)
        {
            Console.WriteLine(v);
        }

    }
}
