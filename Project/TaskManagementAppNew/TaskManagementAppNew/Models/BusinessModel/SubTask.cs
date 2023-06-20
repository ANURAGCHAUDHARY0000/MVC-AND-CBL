using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskManagementAppNew.Models.BusinessModel
{
    [Table("SubTask")]
    public class SubTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CompletedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual Task Task { get; set; }
        [ForeignKey("Task")]
        public int TaskId { get; set; }
    }
}