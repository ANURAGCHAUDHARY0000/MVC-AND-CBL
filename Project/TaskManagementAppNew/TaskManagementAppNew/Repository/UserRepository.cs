using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementAppNew.EF;
using TaskManagementAppNew.Models.BusinessModel;

namespace TaskManagementAppNew.Repository
{
    public class UserRepository
    {
        private TaskManagementDbContext _db;
        public UserRepository()
        {
            _db = new TaskManagementDbContext();
        }
        public List<User> Users { get { return _db.Users.ToList(); } }
    }
}