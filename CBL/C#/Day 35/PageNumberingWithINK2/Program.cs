namespace PageNumberingWithINK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentPage = 21;    
            int numberOfdigits = 5;
            PrintResult(PagesNumberWithInk(currentPage,numberOfdigits));
        }

        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }

        public static int PagesNumberWithInk(int currentPage, int numberofDigits)
        {
            int digitsPerPage = 0;
            while (numberofDigits >= 0)
            {
                int page = currentPage; digitsPerPage = 0;
                while (page != 0)
                {
                    digitsPerPage++; page = page / 10;
                }
                numberofDigits -= digitsPerPage;
                currentPage++;
            }
            return currentPage - 2;
        }


        //private static int PageNumberingWithINK2(int currentPage, int numberOfdigits)
        //{
        //   int currentPagedigit = FindNumberOfDigits(currentPage); //number of digits
        //   if(currentPagedigit <= numberOfdigits)
        //    {

        //    }
           

        //}


        //private static int FindNumberOfDigits(int digits)
        //{
        //    string currentPageString = digits.ToString();
        //    int currentPageLength = currentPageString.Length;
        //    return currentPageLength;
        //}
    }
}