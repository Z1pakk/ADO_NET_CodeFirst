using CodeFirstExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
// For Include
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFContext context = new EFContext())
            {
                context.Persons.Add(new Person()
                {
                    Name = "Bober",
                    DateOfBirth = DateTime.Now,
                    Description = "Жирний бобер",
                    Gender = true
                }); 

                context.SaveChanges();

                foreach (var item in context.Persons.Include(t => t.PersonCoursesOf).ToList())
                {
                    Console.WriteLine(item.Name);
                    foreach (var course in item.PersonCoursesOf)
                    {
                        Console.WriteLine($"Курс: {course.CourseOf.Name}");
                    }
                }
            }
        }
    }
}
