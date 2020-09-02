
using EFcoreProgram;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using static EFcoreProgram.Course;

namespace EFcoreProgram
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        
        public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }
          

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"data source=DESKTOP-1ID32BM\SQLEXPRESS; database=SchoolDB; integrated security=SSPI");
            }
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    Name = "VISHAB"
                };

                var std1 = new Student()
                {
                    Name = "RISHAB"
                };

                var std2 = new Student()
                {
                    Name = "ROHIT"
                };
                var cou = new Course()
                {
                    CourseName = "CSHARP"
                };
                var cou1 = new Course()
                {
                    CourseName = "ANGULAR"
                };
                var cou2 = new Course()
                {
                    CourseName = "ENTITY FRAMEWORK"
                };
                

                context.Students.Add(std);
                context.Students.Add(std1);
                context.Students.Add(std2);

                context.Courses.Add(cou);
                context.Courses.Add(cou1);
                context.Courses.Add(cou2);
             
                context.SaveChanges();
            }

        }
    }
}
    /* var context = new SchoolContext();
     var studentsWithSameName = context.Students
                                       .Where(s => s.Name == "VISHAB")
                                       .ToList();

     Console.WriteLine(studentsWithSameName.Count());
         } 
}*/
