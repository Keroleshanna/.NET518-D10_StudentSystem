using P01_StudentSystem.Data;
using P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static Program()
        {
            // Data Seeding
            StudentSystemDbContext dbContext = new StudentSystemDbContext();

            StudentSystemDbContextSeed.StudentsSeed(dbContext);
            StudentSystemDbContextSeed.CoursesSeed(dbContext);
            StudentSystemDbContextSeed.ResourcesSeed(dbContext);
            StudentSystemDbContextSeed.HomeWorksSeed(dbContext);
        }

        static void Main(string[] args)
        {
            using StudentSystemDbContext context = new();

            var result = context.Courses
                .Where(e => e.Price > 1000)
                .Select(s => new
                {
                    s.CourseId,
                    s.Name,
                    s.StartDate
                });

            foreach (var item in result)
                Console.WriteLine(item);


            try
            {
                Student newStudent = new() { Name = "keroles", Birthday = new DateOnly(1995, 01, 01), PhoneNumber = "01271473839", RegisteredOn = new DateTime(2025, 02, 09) };

                context.Students.Add(newStudent);
                context.SaveChanges(); // I added 11 numbers in PhoneNumber, It can't add it
            }
            catch (Exception ex)
            {
                Console.WriteLine($"I can't add this student becouse {ex.Message}");
            }
        }
    }
}
