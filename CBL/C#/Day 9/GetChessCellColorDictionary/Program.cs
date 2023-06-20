using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace GetChessCellColorDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Cell Location ");
            String s1 = "M5";
            PrintCellColour(GetChessCellColor(s1.ToLower()));
        }

        private static void PrintCellColour(string v)
        {
            Console.WriteLine(v);
        }

        private static string GetChessCellColor(string cell)
        {
            char Column = cell[0];
            int Row = cell[1];
            int Sum = 0;
            Dictionary<char, int> charmap = new Dictionary<char, int>()
            {
                {'a',1 },{'b',2},{'c',3},{'d',4 },{'e',5},{'f',6},{'g',7},{'h',8}
            };

            if (charmap.ContainsKey(Column))
            {
               Sum = charmap[Column];
               Sum = Sum + Row;

                if (Sum % 2 == 1)
                {
                    return "WHITESQUARE";
                }
                return "BLACKSQUARE";
            }
            else
            {
                return "Please Enter COlumn Index From A to H";
            }
                    

        }
    }
}