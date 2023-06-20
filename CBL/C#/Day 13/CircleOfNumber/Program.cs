namespace CircleOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle of Number ");
            int circleOfnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number ");
            int input = int.Parse(Console.ReadLine());
            PrintResult(CircleOfNumber(circleOfnumber, input));

        }

     
        private static int CircleOfNumber(int circleOfnumber, int input)
        {
            //int midpoint = circleOfnumber / 2;
            //if(opposite >= midpoint)
            //{
            //    return opposite - midpoint;
            //}
            //return midpoint + opposite;
            int opposite = 0;
            if(input >= 1 && input <= circleOfnumber)
            {
                opposite = (input + circleOfnumber) % 10;
            }
            return opposite;

        }


        private static void PrintResult(int v)
        {
            Console.WriteLine(v);
        }

    }
}