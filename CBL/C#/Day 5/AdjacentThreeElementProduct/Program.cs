namespace AdjacentThreeElementProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintProducts (AdjacentThreeElementProduct(3, 6, 2, 5, 7, 3));
            PrintProducts(AdjacentThreeElementProduct(3, 6, -2, -5, 7, 3));
        }

        private static int AdjacentThreeElementProduct(params int[] listofnumbers)
        {
            int min_value = int.MinValue;
            for (int i = 0; i < listofnumbers.Length -2; i++)
            {
                if(listofnumbers[i] * listofnumbers[i+1] * listofnumbers[i+2] > min_value)
                {
                    min_value = listofnumbers[i] * listofnumbers[i + 1] * listofnumbers[i + 2];
                }
            }
            return min_value;
                        
        }

        private static void PrintProducts(int number)
        {
            Console.WriteLine(number);
        }

    }
}