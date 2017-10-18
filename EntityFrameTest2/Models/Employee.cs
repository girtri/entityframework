using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameTest2.Models
{
    [Table("HumanResources.Employee")]
    public class Employee
    {
        [Key]
        public int BusinessEntityID { get; set; }

        public int OrganizationLevel {get; set; }

        public string JobTitle {get; set; }

        public DateTime BirthDate {get; set; }

        public char Gender {get; set; }
    }
}
