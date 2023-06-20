using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TaskManagementAppNew.Models.BusinessModel;

namespace TaskManagementAppNew.EF
{
    public class TaskManagementDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        
    }
}