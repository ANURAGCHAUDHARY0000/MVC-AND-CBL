namespace ExtractKthElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int Kthposition = 3;
            PrintExtractedElement(ExtractEachKthElement(elements, Kthposition));
        }

        private static void PrintExtractedElement(int[] ints)
        {
            foreach (int i in ints)
                Console.WriteLine(i);
        }

        private static int[] ExtractEachKthElement(int[] elements, int kthposition)
        {

         List<int> extractedElement = new List<int>();
         for(int i = kthposition -1 ; i < elements.Length; i = i +kthposition)
         {
            extractedElement.Add(elements[i]);
                    
         }

         return extractedElement.ToArray();
            
        }
    }
}