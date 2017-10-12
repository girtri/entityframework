using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameTest2.Models
{
    class PersonMap: EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable("Person.Person");

            HasKey(k => new { k.BusinessEntityID });

            HasMany(p =>p.PersonPhone).WithRequired(p => p.Person)
                .HasForeignKey(ph => ph.BusinessEntityID);

            Ignore(p => p.PayloadProperty);
           
            //esempio proprieà di un campo
            /*
            Property(p => p.FirstName)
                .HasMaxLength(40)
                .IsRequired()
                .HasColumnName("AltroNome");
            */
        }

    }
}
