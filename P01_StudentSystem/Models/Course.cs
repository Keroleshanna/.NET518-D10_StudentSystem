using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        [MaxLength(80)]
        [Unicode]
        public string Name { get; set; }
        [Unicode]
        public string? Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int Price { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }

        public List<Resource> resources { get; set; }

        public List<HomeWork> homeWorks { get; set; }
    }
}
