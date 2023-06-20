using FromValidationApp.Models.BuisnessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FromValidationApp.Service
{
    public class StudentService
    {
        private static List<Student> _students;

        static StudentService ()
        {
            _students = new List<Student> ();
            _students.Add (new Student { Id = 1, Name = "A"});
            _students.Add(new Student { Id = 2, Name = "B" });
            _students.Add(new Student { Id = 3, Name = "C" });
        }

        //public StudentService()
        //{ }

        public List<Student>  Get()
        {
            return _students;
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }
    }
}