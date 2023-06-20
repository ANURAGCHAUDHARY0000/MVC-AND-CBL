namespace CommonCharacterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = "1233";
            String s2 = "1233";
            PrintResult(CommonCharacterCount(s1,s2));
        }

      
        private static int CommonCharacterCount(string s1, string s2)
        {
            char[] chars = s1.ToCharArray();
            char[] chars2 = s2.ToCharArray();
            int commonCharactercount = 0;   
            for(int i = 0; i < chars.Length; i++)
            {
                for(int j = 0; j < chars2.Length; j++)
                {
                    if(chars[i] == chars2[j])
                    {
                        chars2[j] = '*';
                        commonCharactercount++;
                        break;
                    }
                }
            }

            return commonCharactercount;
           
            
        }

        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }


    }
}