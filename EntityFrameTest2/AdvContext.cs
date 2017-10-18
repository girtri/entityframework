using System.Data.Entity;
using EntityFrameTest2.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntityFrameTest2
{
    class AdvContext: DbContext
    {
        public AdvContext(): base("AdventureWorks2012"){}

        public virtual DbSet<Person> People {get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumber {get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType {get; set; }
        public virtual DbSet<Employee> Employees {get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().HasMany(p =>p.PersonPhone).WithRequired(p => p.Person).HasForeignKey(ph => ph.BusinessEntityID);
            modelBuilder.Configurations.Add(new PersonMap());

            // ignora PluralizingTableName convention
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // elimina on delete cascade per default
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
