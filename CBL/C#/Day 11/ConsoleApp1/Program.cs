namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int chunkSize = 3;
            int numberOfChunks = (int)Math.Ceiling((double)array.Length / chunkSize);

            int[,] chunks = new int[numberOfChunks, chunkSize];
            int offset = 0;

            for (int i = 0; i < numberOfChunks; i++)
            {
                int size = chunkSize;
                if (i == numberOfChunks - 1)
                {
                    size = array.Length - offset;
                }

                for (int j = 0; j < size; j++)
                {
                    chunks[i, j] = array[offset + j];
                }

                offset += size;
            }

            for (int i = 0; i < numberOfChunks; i++)
            {
                Console.Write($"Chunk {i + 1}: [");
                for (int j = 0; j < chunkSize; j++)
                {
                    Console.Write(chunks[i, j] + " ");
                }
                Console.WriteLine("]");
            }

        }
    }
}