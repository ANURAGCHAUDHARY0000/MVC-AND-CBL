namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = new string[3] { "abc", "xyz", "pqr" };
           // string [] str2 = AddBorder(str1);
            PrintDetails(AddBorder(str1));
           
        }

        public static string[] AddBorder(string[] border)
        {
            List<string> list = new List<string>();
            list.Add("*****");
            foreach (string str in border)
            {
                list.Add("*" + str + "*");
            }
            list.Add("*****");
            return list.ToArray();
        }

        public static void PrintDetails(string[] printborder)
        {
            foreach (string str in printborder)
            {
                Console.WriteLine(str);
            }
        }


    }






}