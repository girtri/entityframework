using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFrameTest2.Models;

namespace EntityFrameTest2
{
    class AdvContext: DbContext
    {
        public AdvContext(): base("AdventureWorks2012"){}

        public DbSet<Person> Utenti {get; set; }
    }
}
