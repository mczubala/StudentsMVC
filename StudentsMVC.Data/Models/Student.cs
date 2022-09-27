using System.ComponentModel.DataAnnotations;

namespace StudentsMVC.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]    
        [MaxLength(40)]
        public string FirstName { get; set; }
        [Required]    
        [MaxLength(40)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}