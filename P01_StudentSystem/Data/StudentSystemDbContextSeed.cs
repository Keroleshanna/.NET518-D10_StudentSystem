using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal static class StudentSystemDbContextSeed
    {
        public static void StudentsSeed(StudentSystemDbContext dbContext)
        {
            if (!dbContext.Students.Any())
            {
                var studentsData = File.ReadAllText($"{Directory.GetCurrentDirectory()}/Data/students_data.json");
                var students = JsonSerializer.Deserialize<List<Student>>(studentsData);

                if (students?.Count > 0)
                {
                    dbContext.Students.AddRange(students);
                    dbContext.SaveChanges();
                }
            }
        }
        public static void CoursesSeed(StudentSystemDbContext dbContext)
        {
            if (!dbContext.Courses.Any())
            {
                var coursesData = File.ReadAllText($"{Directory.GetCurrentDirectory()}/Data/courses_data.json");
                var courses = JsonSerializer.Deserialize<List<Course>>(coursesData);

                if (courses?.Count > 0)
                {
                    dbContext.Courses.AddRange(courses);
                    dbContext.SaveChanges();
                }
            }
        }
        public static void ResourcesSeed(StudentSystemDbContext dbContext)
        {
            if(!dbContext.Resources.Any())
            {
                var resourcesData = File.ReadAllText($"{Directory.GetCurrentDirectory()}/Data/resources_data.json");
                var resourcesString = JsonSerializer.Deserialize<List<Resource>>(resourcesData);

                if(resourcesString?.Count > 0)
                {
                    dbContext.Resources.AddRange(resourcesString);
                    dbContext.SaveChanges();
                }
            }
        }
        public static void HomeWorksSeed(StudentSystemDbContext dbContext)
        {
            if (!dbContext.HomeWorks.Any())
            {
                var homeWorksFile = File.ReadAllText($"{Directory.GetCurrentDirectory()}/Data/submissions_data.json");
                var homeWorksString = JsonSerializer.Deserialize<List<HomeWork>>(homeWorksFile);

                if(homeWorksString?.Count > 0)
                {
                    dbContext.HomeWorks.AddRange(homeWorksString);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
