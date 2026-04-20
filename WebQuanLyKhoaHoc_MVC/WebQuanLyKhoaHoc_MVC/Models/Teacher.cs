using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace learnMVC.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }

        // Mối quan hệ: 1 giáo viên dạy nhiều lớp học phần
        [ValidateNever]
        public ICollection<CourseClass> CourseClasses { get; set; }
    }
}