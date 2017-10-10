//using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameTest2.Models
{
    [Table("Person.Person")]
    public class Person
    {
        public Person()
        {
            PersonPhone = new HashSet<PhoneNumber>();
        }

        [Key]
        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<PhoneNumber> PersonPhone { get; set; }
    }
}
