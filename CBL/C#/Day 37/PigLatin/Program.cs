namespace PigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "eight";
            Console.WriteLine(PigLatin(s1.ToLower())); 
        }

        private static string PigLatin(string s1)
        {
            char[] chars = s1.ToCharArray();
            string result = string.Empty;
            string result1 = string.Empty;
            int firstVowelIndex = -1;

            
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u')
                {
                    firstVowelIndex = i;
                    break;
                }
            }

            if (firstVowelIndex == 0) 
            {
                result = s1 + "way";
                return result;
            }
            else if (firstVowelIndex > 0) 
            {
                result = s1.Substring(firstVowelIndex) + s1.Substring(0, firstVowelIndex);
            }
           
            return result + "ay";
        }
    }
}
