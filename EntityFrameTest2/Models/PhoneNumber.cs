using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameTest2.Models
{
    [Table("Person.PersonPhone")]
    public class PhoneNumber
    {        
        [Key, Column(Order = 0)]
        public int BusinessEntityID {get; set; }

        [Key, Column("PhoneNumber", Order = 1)]
        public string Number {get; set; }

        [Key, Column(Order = 2)]
        public int PhoneNumberTypeID {get; set; }

        public virtual Person Person {get; set; }
    }
}

