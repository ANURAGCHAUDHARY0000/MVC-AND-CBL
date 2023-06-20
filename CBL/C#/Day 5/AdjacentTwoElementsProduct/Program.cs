namespace AdjacentTwoElementsProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintProduct(AdjacentTwoElementsProduct(3,6,2,5,7,3));
            PrintProduct(AdjacentTwoElementsProduct(3,6,-2,-5,7,3));

        }


        private static int AdjacentTwoElementsProduct(params int[] listofnumbers)
        {
            int min_num = int.MinValue;
            for(int i = 0; i < listofnumbers.Length -1 ; i++)
            {
                if(listofnumbers[i]  * listofnumbers[i+1] > min_num)        
                {
                    min_num = listofnumbers[i] * listofnumbers[i+1];
                }
            }
            return min_num; 
        
        }



        private static void PrintProduct(int number)
        {
            Console.WriteLine(number);
        }

    }
}