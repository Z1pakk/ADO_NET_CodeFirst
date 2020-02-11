using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("BoberConnection")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
