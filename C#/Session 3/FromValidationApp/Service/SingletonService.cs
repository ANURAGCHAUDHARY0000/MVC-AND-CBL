using FromValidationApp.Models.BuisnessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FromValidationApp.Service
{
    public class SingletonService
    {
        private static SingletonService instance;
        private static List<Student> _students;

        static SingletonService()
        {
            _students = new List<Student>();
            _students.Add(new Student { Id = 1, Name = "ASingleton" });
            _students.Add(new Student { Id = 2, Name = "BSingleton" });
            _students.Add(new Student { Id = 3, Name = "CSingleton" });
        }

        public static SingletonService GetInstance()
        {
            if(instance == null)
                instance = new SingletonService();

            return instance;
        }

        public List<Student> Get()
        {
            return _students;
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

    }
}