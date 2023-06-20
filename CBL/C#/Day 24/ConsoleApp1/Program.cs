namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 1, 1, 2 }, { 8, 5, 0, 4 }, { 2, 1, 3, 6 } };
            int position = 2;
            PrintResult(ExtractMatrixColumn(matrix, position));
        }

        private static void PrintResult(List<int> list)
        {
            foreach(var res in list)
            {
                Console.WriteLine(res);
            }
        }

        private static List<int> ExtractMatrixColumn(int[,] matrix, int position)
        {
            List<int> column = new List<int>();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(var j =0 ; j < matrix.GetLength(1); j++)
                {
                    if (j == position)
                    {
                        column.Add(matrix[i, j]);
                    }
                }
            }
            return column;
        }
    }
}