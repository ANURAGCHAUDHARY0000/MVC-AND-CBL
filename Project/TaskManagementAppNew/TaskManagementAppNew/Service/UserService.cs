using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagementAppNew.EF;
using TaskManagementAppNew.Models.BusinessModel;
using TaskManagementAppNew.Repository;

namespace TaskManagementAppNew.Service
{
    public class UserService
    {
        private static UserService _instance;
        private UserRepository _repository;
        private TaskManagementDbContext _db;
        public UserService()
        {
            _repository = new UserRepository();
            _db = new TaskManagementDbContext();
        }
        public static UserService GetInstance()
        {
            if (_instance == null)
                _instance = new UserService();
            return _instance;
        }
        public User GetUser(string emailId,string password)
        {
            if (emailId != null && password!=null)
            {
                foreach (var user in _repository.Users)
                {
                    if (emailId.Equals(user.Email) && password.Equals(user.Password) && user.IsActive)
                    {
                        return user;
                    }
                }
            }
           
            return null;
        }
        public void AddUser (User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        public void EditUser(int id,User newUser)
        {
            var user = _db.Users.Find(id);
            user.Name = newUser.Name;
            user.Password = newUser.Password;
            user.Email = newUser.Email;
            user.IsActive = newUser.IsActive;
            _db.SaveChanges();
        }
        public void DisableUser(int id)
        {
            var user = _db.Users.Find(id);
            user.IsActive = false;
            _db.SaveChanges();
        }

        public void EnableUser(int id)
        {
            var user = _db.Users.Find(id);
            user.IsActive = true;
            _db.SaveChanges();
        }

        public List<User> GetAllUser()
        {
            return _db.Users.ToList();
        }
    }
}