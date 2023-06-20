using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementAppNew.Models.BusinessModel;

namespace TaskManagementAppNew.Models.ViewModels
{
    public class UserVM
    {
        public List<User> Users { get; set; }
        public int Count { get; set; }
    }
}