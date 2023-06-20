using CollegeCoreLib.Entiy;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCoreLib.EF
{
    public class Entity  : DbContext
    {
       public DbSet<College> Colleges { get; set; } 
    }
}
