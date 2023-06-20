namespace CheckDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] domain = {"en.wiki.org","codefight.com","happy.net","code.info" };
            PrintResult(CheckDomainType(domain));
        }

        private static void PrintResult(string[] strings)
        {
            foreach (string s in strings)   
                Console.WriteLine(s);
        }

        private static string [] CheckDomainType(string[] domain)
        {
            List<string> list = new List<string>();
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                {"org","Organisation"},{"com","Commercial"},{"net","network"},{"info","Information"}
            };

            for(int i = 0; i < domain.Length; i++)
            {
                int lastDotPosition = domain[i].LastIndexOf('.');
                string lastPart = domain[i].Substring(lastDotPosition + 1);
                if(result.ContainsKey(lastPart))
                {
                    list.Add(result[lastPart]);
                }
            }
            return list.ToArray();
        }
    }
}