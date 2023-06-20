using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeCoreLib;
using CollegeCoreLib.EF;
using CollegeCoreLib.Entiy;

namespace ConsoleAppCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddCollege();
            Console.WriteLine("End of Add College");
            Console.ReadLine();
        }

        public static async Task AddCollege()
        {
            College college = new College { Name = "IIT", Id = 101, Location = "Delhi" };
            Entity entity = new Entity();
            entity.Colleges.Add(college);
            int rows = await entity.SaveChangesAsync();
            Console.WriteLine(rows);
            

        }
    }
}
