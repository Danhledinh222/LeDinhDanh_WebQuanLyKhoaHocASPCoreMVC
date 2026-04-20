using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace learnMVC.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        // Khóa ngoại liên kết với Student
        [Required(ErrorMessage = "Vui lòng chọn sinh viên")]
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        [ValidateNever] 
        public Student Student { get; set; }

        // Khóa ngoại liên kết với CourseClass
        [Required(ErrorMessage = "Vui lòng chọn lớp học phần")]
        public int CourseClassId { get; set; }

        [ForeignKey("CourseClassId")]
        [ValidateNever] 
        public CourseClass CourseClass { get; set; }

        [Range(0, 10, ErrorMessage = "Điểm số phải nằm trong khoảng 0 - 10")]
        public float? Grade { get; set; }
    }
}