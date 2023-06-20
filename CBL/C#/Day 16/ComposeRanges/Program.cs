using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace ComposeRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array : ");
            int[] arr1  = { 1, 2, 3, 5, 6, 7, 9 };
            PrintResult(ComposeRanges(arr1));
        }

        private static void PrintResult(List<string> strings)
        {
            Console.Write("[");
            foreach (String i in strings)
                Console.Write(i + ", ");

            Console.Write("]");
        }

        private static  List<string> ComposeRanges(int[] arr1)
        {
            List<string> composedList = new List<string>();
            int Length = 1;
            if(arr1.Length == 0)
            {
                return composedList;    
            }
           
            for(int i = 1; i <= arr1.Length; i++)
            {
                if(i == arr1.Length  || arr1[i] - arr1[i-1] != 1)
                {
                    if (Length == 1)
                    {
                        composedList.Add(
                            String.Join("", arr1[i - Length]));
                    }

                    else
                    {
                     
                        composedList.Add(arr1[i - Length] +
                        " -> " + arr1[i - 1]);

                        Length = 1;
                    }
                }

                else
                {
                    Length++;
                }
            }

            return composedList;
        }
    }
}