using System.Linq;

namespace ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -955;
            PrintReverseNum(ReverseInt(num));
            PrintReverseNum(ReverseIntWithString(num));
        }
          
    
        private static int ReverseInt(int num)
        {
            int reverseInteger = 0;
            while(num != 0)
            {
               int remainder =  num % 10;
               reverseInteger = (reverseInteger * 10) + remainder;
               num = num / 10;
            }
            
            return reverseInteger;
        }


        private static int ReverseIntWithString(int num)
        {
            int result = Math.Abs(num);
            string reverseString = result.ToString();
            string number = new string(reverseString.Reverse().ToArray());
            result = Convert.ToInt32(number);
            if(num > 0)
            {
                return result;
            }
            return -result;

        }
        private static void PrintReverseNum(int v)
        {
            Console.WriteLine(v);
        }


    }
}