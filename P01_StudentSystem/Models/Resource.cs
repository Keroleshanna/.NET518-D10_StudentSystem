using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Models
{
    [Flags]
    enum ResourceType
    {
        Video = 1,
        Presentation = 2,
        Document = 4,
        Other = 8
    }
    internal class Resource
    {
        public int ResourceId { get; set; }
        [MaxLength(50)]
        [Unicode]
        public string Name { get; set; }
        public string? Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        public Course Course {  get; set; }
    }
}
