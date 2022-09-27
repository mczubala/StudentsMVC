using System.Collections.Generic;
using StudentsMVC.Data.Models;

namespace StudentsMVC.Models
{
    public class GreetingViewModel
    {
        public  IEnumerable<Student> Students { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}