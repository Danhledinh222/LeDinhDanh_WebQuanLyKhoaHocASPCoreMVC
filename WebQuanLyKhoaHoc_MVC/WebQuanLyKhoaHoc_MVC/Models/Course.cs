using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace learnMVC.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        public int Credits { get; set; } // Số tín chỉ

        // Mối quan hệ: 1 môn học có thể mở nhiều lớp học phần
        [ValidateNever]
        public ICollection<CourseClass> CourseClasses { get; set; }
    }
}