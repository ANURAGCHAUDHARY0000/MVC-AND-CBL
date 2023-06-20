namespace RatingThreshold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 3, 4 };
            //jaggedArray[1] = new int[] { 3, 3, 3, 4 };
            //jaggedArray[2] = new int[] { 4 };
            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[] {3,2};
            jaggedArray[1] = new int[] { 3, 3,3,4};
            jaggedArray[2] = new int[] {4};
            jaggedArray[3] = new int[] {3,5};
            jaggedArray[4] = new int[] {3};
            double ratingThreshold = 3.5;
            PrintResult(FindRatingThreshold(jaggedArray,ratingThreshold));
        }

        private static void PrintResult(List<int> list)
        {
           foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static  List<int> FindRatingThreshold(int[][] jaggedArray, double threshold)
        {
            int sum = 0;
            float avg = 0;
            List<int> list = new List<int>();

            for (int n = 0; n < jaggedArray.Length; n++)
            {

                for (int k = 0; k < jaggedArray[n].Length; k++)
                {
                    sum += jaggedArray[n][k];
                                       
                }
                avg = (float)sum / jaggedArray[n].Length;
                if (avg < threshold)
                {
                    list.Add(n);
                }
                sum = 0;
            }

            return list;
        }
    }
}