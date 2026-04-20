using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation; // Phải using thư viện này

namespace learnMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string Name { get; set; }

        public string Email { get; set; }

        [ValidateNever]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}