using System.Web.Http;
using System.Collections.Generic;
using StudentsMVC.Data.Models;
using StudentsMVC.Data.Services;

namespace StudentsMVC.Api
{
    public class StudentsController : ApiController
    {
        private readonly IStudentData db;

        public StudentsController(IStudentData db)
        {
            this.db = db;
        }

        public IEnumerable<Student> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}