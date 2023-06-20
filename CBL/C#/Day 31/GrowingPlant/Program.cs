namespace GrowingPlant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upSpeed = 100;
            int downSpeed = 10;
            int desiredHeight = 800;
            PrintResult(GrowingPlant(upSpeed, downSpeed, desiredHeight));
           
        }

        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }

        private static int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int result = 0;
            int count = 0;
            while(result <= desiredHeight)
            {
                result = result + upSpeed;
                if(result == desiredHeight)
                {
                    count++;
                    break;
                }
                result = result - downSpeed;
                count++;
            }
            return count;
            
        }
    }
}