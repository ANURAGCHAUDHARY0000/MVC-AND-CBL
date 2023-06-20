namespace FirstDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2,1,3,5,3,2 };
            PrintResult(FindFirstDuplicate(ints));
            PrintResult(FindFirstDuplicateWithHash(ints));
        }

        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }

        private static int FindFirstDuplicate(int[] ints)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < ints.Length; i++)
            {
                for(int j = i+1; j < ints.Length; j++)
                {
                    if(ints[i] == ints[j])
                    {
                        list.Add(j);
                    }
                }

            }
            if(list.Count == 0)
                return -1;
           
            int result = list.AsQueryable().Min();
            return ints[result];
                        
        }


        private static int FindFirstDuplicateWithHash(int[] ints)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in ints)
            {
                if (set.Contains(i))
                {
                    return i;
                }
                set.Add(i);
            }
            return -1;
        }
    }
}