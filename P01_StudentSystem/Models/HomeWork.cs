using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{
    enum ContentType
    {
        Application = 1, 
        Pdf = 2, 
        Zip =3
    }
    internal class HomeWork
    {
        public int HomeWorkId { get; set; }
        [Unicode(false)]
        public string Content { get; set; } 
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }




        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        
    }
}
