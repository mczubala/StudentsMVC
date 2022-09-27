using System.Collections.Generic;
using StudentsMVC.Data.Models;

namespace StudentsMVC.Data.Services
{
    public interface IStudentData
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        void Add(Student student);

    }
}