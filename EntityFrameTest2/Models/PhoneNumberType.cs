using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameTest2.Models
{
    [Table("Person.PhoneNumberType")]
    public class PhoneNumberType
    {
        [Key]
        public int PhoneNumberTypeID {get; set; }

        public string Name {get; set; }

        public DateTime ModifiedDate {get; set; }
    }
}
