using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameTest2.Models
{
    [Table("Person.PersonPhone")]
    class PhoneNumber
    {
        [Key]
        public int BusinessEntityID {get; set; }

        [Column("PhoneNumber")]
        public string Number {get; set; }
    }
}

