using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementAppNew.EF;
using TaskManagementAppNew.Models.BusinessModel;

namespace TaskManagementAppNew.Repository
{
    public class TaskRepository
    {
        private TaskManagementDbContext _db;
        public TaskRepository()
        {
            _db = new TaskManagementDbContext();
        }
        public List<Task> Tasks { get { return _db.Tasks.ToList(); } }
    }
}