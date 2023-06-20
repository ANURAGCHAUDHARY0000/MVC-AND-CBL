using System;

namespace ChunkArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array :");
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int chunk = 3;
            PrintChunkedArray(ChunkArray(arr, chunk));
        }

        private static int [,] ChunkArray(int[] array, int chunkSize)
        {
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

            return chunks;
           
        }


        public static void PrintChunkedArray(int[,] chunked)
        {

            for (int i = 0; i < chunked.GetLength(0); i++)
            {
                Console.Write($"Chunk {i + 1}: [");
                for (int j = 0; j < chunked.GetLength(1); j++)
                {
                    Console.Write(chunked[i, j] + " ");
                }
                Console.WriteLine("]");
            }

        }

    }
}