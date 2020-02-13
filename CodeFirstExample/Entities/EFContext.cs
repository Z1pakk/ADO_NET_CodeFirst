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

        public DbSet<PersonCreditInfo> PersonCreditInfoes { get; set; }

        public DbSet<PersonOrders> PersonOrders { get; set; }
    }
}
