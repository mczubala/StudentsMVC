using System.Configuration;
using System.Web.Mvc;
using StudentsMVC.Models;

namespace StudentsMVC.Controllers
{
    public class GreetingController : Controller
    {
        // GET
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            model.Name = name ?? "no name";
            return View(model);
        }
    }
}