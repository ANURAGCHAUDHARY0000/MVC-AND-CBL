namespace FlattenNestedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] strings = { { "a" }, { "b" } };
            int[,,] ints = {
                { { 1, 2 } },
                { { 3, 4 } },
                {  { 5 ,6} }
            };

           
            PrintResult(FlattenNestedArray(ints));
            PrintResult(FlattenNestedArray(strings));
        }

        private static void PrintResult<T>(T[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                Console.Write(objects[i]);
               
            }
            Console.WriteLine();
        }

        private static T[] FlattenNestedArray<T>(T[,,] obj)
        {
            int totalLength = obj.Length;
            T[] result = new T[totalLength];
            int index = 0;

            foreach (T item in obj)
            {
                result[index++] = item;
            }

            return result;
        }

        private static T[] FlattenNestedArray<T>(T[,] obj)
        {
            int totalLength = obj.Length;
            T[] result = new T[totalLength];
            int index = 0;

            for (int i = 0; i < obj.GetLength(0); i++)
            {
                for (int j = 0; j < obj.GetLength(1); j++)
                {
                    result[index++] = obj[i, j];
                }
            }

            return result;
        }
    }
}
