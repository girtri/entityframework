using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameTest2.Models
{
    public class Person
    {
        public Person()
        {
            PersonPhone = new HashSet<PhoneNumber>();
        }

        public int BusinessEntityID { get; set; }

        public string PersonType { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Suffix { get; set; }

        public int EmailPromotion { get; set; }

        public DateTime ModifiedDate {get; set; }

        public virtual ICollection<PhoneNumber> PersonPhone { get; set; }

        // proprietà da scollegara al controllo dell'Entity Framework
        public string PayloadProperty {get; set; }
    }
}
