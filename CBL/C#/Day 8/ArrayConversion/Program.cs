namespace ArrayConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7,8};

            PrintArray(ArrayConversion(arr1));
        }

        private static int[] ArrayConversion(int[] arr)
        {

            while (arr.Length > 1)
            {
               List<int> temp = new List<int>();
              // 1. Pairwise Sum

               for(int i = 0; i < arr.Length - 1; i+=2)
               {
                    temp.Add(arr[i] + arr[i+1]);
               }
               if(arr.Length %2 == 1)
               {
                    temp.Add(arr[arr.Length-1]);
               }

               arr = temp.ToArray();
               temp.Clear();

                //2. Pirwsie Multiply

                for (int i = 0; i < arr.Length - 1; i += 2)
                {
                    temp.Add(arr[i] * arr[i + 1]);
                }
                if (arr.Length % 2 == 1)
                {
                    temp.Add(arr[arr.Length - 1]);
                }

                arr = temp.ToArray();

            }
            return new int[] { arr[0] };
        }

        private static void PrintArray(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }

    }
}