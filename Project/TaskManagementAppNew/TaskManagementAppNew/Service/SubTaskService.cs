using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementAppNew.EF;
using TaskManagementAppNew.Models.BusinessModel;
using TaskManagementAppNew.Repository;

namespace TaskManagementAppNew.Service
{
    public class SubTaskService
    {
        private TaskManagementDbContext _dbContext;
        public SubTaskService()
        {
            _dbContext = new TaskManagementDbContext();
        }
        public void AddSubTask(SubTask subTask)
        {
            _dbContext.SubTasks.Add(subTask);
            _dbContext.SaveChanges();
        }
        public void EditSubTask(int id,SubTask NewSubtask)
        {
            var subTask = _dbContext.SubTasks.Find(id);
            subTask.Title = NewSubtask.Title;
            subTask.Description = NewSubtask.Description;
            subTask.CreatedOn = NewSubtask.CreatedOn;
            subTask.CompletedOn = NewSubtask.CompletedOn;
            _dbContext.SaveChanges();
        }
        public void DeleteSubTask(int id)
        {
            var subTask = _dbContext.SubTasks.Find(id);
            _dbContext.SubTasks.Remove(subTask);
            _dbContext.SaveChanges();
        }
        public List<SubTask> GetAllSubTask(int?id)
        {
            return _dbContext.SubTasks.Where(x => x.TaskId == id).ToList();
        }

        public SubTask GetSubTaskById(int id)
        {
            return _dbContext.SubTasks.Find(id);
        }
    }
}