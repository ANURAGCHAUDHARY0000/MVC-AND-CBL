using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementAppNew.EF;
using TaskManagementAppNew.Migrations;
using TaskManagementAppNew.Models.BusinessModel;
using TaskManagementAppNew.Repository;

namespace TaskManagementAppNew.Service
{
    public class TaskService
    {
        private TaskManagementDbContext _dbContext;
        public TaskService()
        {
            _dbContext = new TaskManagementDbContext();
        }
        public void AddTask(Task task)
        {
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
        }
        public void EditTask(int id, Task newTask)
        {
            var task = _dbContext.Tasks.Find(id);
            task.Title = newTask.Title;
            task.Discription = newTask.Discription;
            task.Priority = newTask.Priority;
            task.CompletedOn = newTask.CompletedOn;
            _dbContext.SaveChanges();
        }
        public List<Task> GetAllTask(int?userId)
        {
            return _dbContext.Tasks.Where(x => x.UserId == userId).ToList(); 
        }
        public void DeleteTask(int id)
        {
            Task task = _dbContext.Tasks.Find(id);
            List<SubTask> tasks = _dbContext.SubTasks.Where(x => x.TaskId == id).ToList();
            _dbContext.Tasks.Remove(task);
            foreach(SubTask subTask in tasks)
            {
                _dbContext.SubTasks.Remove(subTask);
            }
            _dbContext.SaveChanges();
        }

        public Task GetTaskById(int id)
        {
            return _dbContext.Tasks.Find(id);
        }
    }
}