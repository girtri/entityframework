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
            HasMany(p =>p.PersonPhone).WithRequired(p => p.Person)
                .HasForeignKey(ph => ph.BusinessEntityID);
           
        }

    }
}
