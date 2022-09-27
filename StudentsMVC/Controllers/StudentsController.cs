using System.Web.Mvc;
using StudentsMVC.Data.Models;
using StudentsMVC.Data.Services;

namespace StudentsMVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentData db;
        public StudentsController(IStudentData db)
        {
            this.db = db;
        }
        
        // GET
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Add(student);
                return RedirectToAction("Details", new { id = student.Id });
            }
            return View();
        }
    }
}