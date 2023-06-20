namespace FancyRide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] uberRide = { "UberX", "UberXL", "UberPlus", "UberBlack", "UberSUV" };
            int totalDistance = 10;
            int affordableamount = 20;
            PrintResult(FancyRide(uberRide, totalDistance, affordableamount));
        }

        private static void PrintResult(string v)
        {
            Console.WriteLine(v);
        }

        private static string FancyRide(string[] uberRide, int totalDistance, int affordableamount)
        {

           double totalAmount = 0;
           string fancyCar = string.Empty;
           Dictionary<string, double> checkFancyride = new Dictionary<string, double>
           {
               {"UberX", .3}, {"UberXL", .5}, {"UberPlus", .7}, {"UberBlack", 1}, {"UberSUV", 1.3}
           };

            for (int i = 0; i < uberRide.Length; i++)
            {
                if (checkFancyride.ContainsKey(uberRide[i]))
                {
                    totalAmount = checkFancyride[uberRide[i]] * totalDistance;
                    if(i == uberRide.Length - 1)
                    {
                        fancyCar = uberRide[i];
                    }
                }

                if(totalAmount > affordableamount)
                {
                    fancyCar = uberRide[i-1];
                    break;  
                }
                else if(totalAmount == affordableamount) 
                {
                    fancyCar = uberRide[i];
                    break;
                }

             }

            return fancyCar;

        }
    }
}