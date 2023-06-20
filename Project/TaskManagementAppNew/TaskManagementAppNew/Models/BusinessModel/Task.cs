using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskManagementAppNew.Models.BusinessModel
{
    [Table("Task")]
    public class Task
    {
        public int Id { get; set; }
        public string Discription { get; set; }
        public string Title { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime CompletedOn { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual ICollection<SubTask> SubTasks { get; set; }
    }
    public enum Priority
    {
        High,
        Low,
        medium
    }
}