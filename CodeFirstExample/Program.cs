using CodeFirstExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            }
        }
    }
}
