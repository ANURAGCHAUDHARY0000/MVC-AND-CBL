using System.Data.Common;
using System.Xml;

namespace GetChessCellColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Cell Location ");
                String s1 = Console.ReadLine();
                //String s1 = "H1";
                PrintCellColour(GetChessCellColor(s1.ToLower()));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
        }

        private static void PrintCellColour(string v)
        {
            Console.WriteLine(v);
        }

        private static string  GetChessCellColor(string cell)
        {
            char Column = cell[0];
            int row = cell[1];
            int sum;
            if (row > 1 && row < 8)
            {
                switch (Column)
                {
                    case 'a': Column = '1'; break;
                    case 'b': Column = '2'; break;
                    case 'c': Column = '3'; break;
                    case 'd': Column = '4'; break;
                    case 'e': Column = '5'; break;
                    case 'f': Column = '6'; break;
                    case 'g': Column = '7'; break;
                    case 'h': Column = '8'; break;
                    default:
                        throw new Exception("Not Found");
                }
                sum = row + Column;

                if (sum % 2 == 1)
                {
                    return "WHITESQUARE";
                }
                return "DARKSQUARE";
            }
            return "Please Enter Valid Index From 1 to 8";
            

        }
    }
}