using P01_StudentSystem.Data;

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
            
        }
    }
}
