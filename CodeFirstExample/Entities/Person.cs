using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entities
{
    [Table("tblPersons")]
    public class Person
    {
        public Person()
        {
            PersonCoursesOf = new HashSet<PersonCourse>();
            PersonOrdersOf = new HashSet<PersonOrders>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }

        [Required]
        public bool Gender { get; set; }

        public virtual PersonCreditInfo PersonCreditInfoOf { get; set; }

        public virtual ICollection<PersonOrders> PersonOrdersOf { get; set; }

        public ICollection<PersonCourse> PersonCoursesOf { get; set; }
    }
}
