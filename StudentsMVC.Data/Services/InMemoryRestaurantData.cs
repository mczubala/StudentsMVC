using System;
using System.Collections.Generic;
using System.Linq;
using StudentsMVC.Data.Models;

namespace StudentsMVC.Data.Services
{
    public class InMemoryStudentData : IStudentData
    {
        List<Student> _students;

        public InMemoryStudentData()
        {
            _students = new List<Student>()
            {
                new Student { Id = 1, FirstName = "Adam", LastName = "Adamowicz", Age = 22 , Gender = "male"},
                new Student { Id = 2, FirstName = "Basia", LastName = "Basiowicz", Age = 33 , Gender = "female"},
                new Student { Id = 3, FirstName = "Czarek", LastName = "Czarkowski", Age = 44 , Gender = "none"},

            };
        }
        public IEnumerable<Student> GetAll()
        {
            return _students.OrderBy(r => r.LastName);
        }

        public Student Get(int id)
        {
            return _students.FirstOrDefault(x => x.Id == id);
        }
        public void Add(Student student)
        {
            _students.Add(student);
            student.Id = _students.Max(r => r.Id) + 1;
        }
    }
}
