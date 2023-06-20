using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementAppNew.Models.BusinessModel;

namespace TaskManagementAppNew.Models.ViewModels
{
    public class SubTaskVM
    {
        public List<SubTask> SubTasks { get; set; }
        public int Count { get; set; }
    }
}