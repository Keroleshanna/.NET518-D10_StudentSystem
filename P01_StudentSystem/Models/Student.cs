using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        
        [MaxLength(100)]
        [Unicode]
        public string Name { get; set; }

        [StringLength(10, MinimumLength = 10)]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateOnly? Birthday { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        
        public List<HomeWork> works { get; set; }

    }
}
