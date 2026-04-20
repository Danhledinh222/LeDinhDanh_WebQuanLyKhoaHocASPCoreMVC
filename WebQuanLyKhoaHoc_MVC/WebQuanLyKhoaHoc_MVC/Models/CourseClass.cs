using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace learnMVC.Models
{
    public class CourseClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập học kỳ")]
        public string Semester { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập năm học")]
        [Range(2000, 2100, ErrorMessage = "Năm học không hợp lệ")]
        public int Year { get; set; }

        // Khóa ngoại liên kết với Course
        [Required(ErrorMessage = "Vui lòng chọn môn học")]
        [Display(Name = "Môn Học")]
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        [ValidateNever] // Bỏ qua validate
        public Course Course { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn giảng viên")]
        [Display(Name = "Giảng Viên")]
        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        [ValidateNever] // Bỏ qua validate
        public Teacher Teacher { get; set; }
        [ValidateNever] // Bỏ qua validate
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}