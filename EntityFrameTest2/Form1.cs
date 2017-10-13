using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using EntityFrameTest2.Models;

namespace EntityFrameTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdQuery1_Click(object sender, EventArgs e)
        {
            using (var context = new AdvContext()) {
                var query = from utente in context.People
                    where utente.FirstName == "Roberto" && utente.LastName.Contains("ar")
                    orderby utente.LastName ascending
                    select utente;

                // selezione di un singolo record
                var first = query.First();
                var firstOrNull = query.FirstOrDefault();

                // method
                var methodQuery = context.People.Where(p => p.BusinessEntityID <= 6);
                Console.WriteLine("fine");
            }
        }

        private void cmdQuantifiers_Click(object sender, EventArgs e)
        {
            using (var context = new AdvContext()) {
                var hasDoes = (from utente in context.People
                    where utente.LastName == "Doe"
                    select utente).Any();

                hasDoes = context.People.Any(p => p.LastName == "Doe");
                var allHaveJ = context.People.All(p => p.FirstName.Contains("J"));
            }
        }

        private void cmdRelation_Click(object sender, EventArgs e)
        {
            using (var context = new AdvContext()) {
                //context.Configuration.LazyLoadingEnabled = true;
                //var query = context.People.Where(w => w.BusinessEntityID < 4).Include(p => p.PhoneNumbers).ToList();

                /*
                var query2 = (from utente in context.People.Include(p => p.PersonPhone)
                             where utente.BusinessEntityID < 4
                             select utente).ToList();
                */

                var query = (from utente in context.People
                             where utente.BusinessEntityID < 4
                             select utente).ToList();

                foreach (Person p in query) {
                    Console.WriteLine(p.PersonPhone.FirstOrDefault()?.Number);
                }
                
                /*
                var query2 = from utente in context.People.Include(p => p.PersonPhone)
                    where utente.PersonPhone.Any(ph => ph.Number.StartsWith("6"))
                    select utente;

                foreach (Person p in query2) {
                    Console.WriteLine(p.PersonPhone.FirstOrDefault()?.Number);
                }
                */
                
                Console.WriteLine("fine");
            }
        }

        private void cmdProjections_Click(object sender, EventArgs e)
        {
            using(var context = new AdvContext()) {
                // demo anonymous type
                var query = from onePerson in context.People
                    where onePerson.BusinessEntityID <= 6
                    orderby onePerson.LastName, onePerson.FirstName
                    select new
                    {
                        Last = onePerson.LastName,
                        First = onePerson.FirstName
                    };

                foreach (var p in query) {
                    Console.WriteLine(p.Last);
                }

                // demo class type
                var query2 = from onePerson in context.People
                    where onePerson.BusinessEntityID <= 6
                    orderby onePerson.LastName, onePerson.FirstName
                    select new PersonInfo
                    {
                        LastName = onePerson.LastName,
                        FirstName = onePerson.FirstName
                    };

                foreach (var p in query2) {
                    Console.WriteLine(p.LastName);
                }

                Console.WriteLine("fine");
            }
        }

        private void cmdQuery2_Click(object sender, EventArgs e)
        {
            using(var context = new AdvContext()) {
                // demo multiple step query
                var query = from onePerson in context.People
                    where onePerson.BusinessEntityID <= 10
                    select new
                    {
                        onePerson.EmailPromotion,
                        onePerson.LastName
                    };

                query = query.OrderBy(p => p.LastName);
                //esegui la query solo in questo momento!
                var sum = query.Sum(p => p.EmailPromotion);
                Console.WriteLine("somma = {0}", sum);

                // demo utilizzo di "funzioni aggiuntive" (DbFunctions) nelle query
                var query2 = from onePerson in context.People
                    where onePerson.BusinessEntityID <= 6 && DbFunctions.AddDays(onePerson.ModifiedDate, 2) > new DateTime(1970,1,1)
                    select new
                    {
                        onePerson.LastName,
                        onePerson.ModifiedDate
                    };

                foreach (var p in query2) {
                    Console.WriteLine("Nome: {0}, DataModifica: {1}", p.LastName, p.ModifiedDate);
                }
            }
        }

        private void cmdPaging_Click(object sender, EventArgs e)
        {
            using(var context = new AdvContext()) {
                int pageNumber = 1;
                int pageSize = 10;

                // NB: è obbligatorio usare la clausola OrdrBy !!!
                var people = context.People
                    .OrderBy(p => p.LastName)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize);

                foreach (var p in people) {
                    Console.WriteLine("Cognome: {0}, Nome: {1}", p.LastName, p.FirstName);
                }
            }
        }

        private void cmdJoin_Click(object sender, EventArgs e)
        {
            using(var context = new AdvContext()) {
                // demo INNER JOIN
                var query = from number in context.PhoneNumber
                    join numberType in context.PhoneNumberType
                    on number.PhoneNumberTypeID equals numberType.PhoneNumberTypeID
                    where number.BusinessEntityID <= 6
                    select new
                    {
                        number.Number,
                        numberType.Name
                    };

                foreach (var nr in query) {
                    Console.WriteLine("Number: {0}, Type: {1}", nr.Number, nr.Name);
                }

                // demo LEFT OUTER JOIN
                /*
                var query2 = from person in context.People
                    join personType in context.PersonTypes
                    on person.PersonTypeId equals personType.PersonTypeId into finalGroup
                    from groupedData in finalGroup.DefaultIfEmpty()
                    select new
                    {
                        person.LastName,
                        person.FirstName,
                        TypeName = groupedData.TypeName ?? "Unknown"
                    };
                */
            }
        }

        private void cmdGroupby_Click(object sender, EventArgs e)
        {
            using(var context = new AdvContext()) {
                var query = from onePerson in context.People
                    group onePerson by new { onePerson.ModifiedDate.Month }
                    into monthGroup
                    select new
                    {
                        Month = monthGroup.Key.Month,
                        Count = monthGroup.Count()
                    };

                foreach (var gr in query) {
                    Console.WriteLine("Mese: {0}, Count: {1}", gr.Month, gr.Count);
                }
            }
        }

        private void cmdSelectmany_Click(object sender, EventArgs e)
        {
            using(var context = new AdvContext()) {
                var query = from onePerson in context.People
                            from onePhone in onePerson.PersonPhone
                    where onePerson.BusinessEntityID <= 10
                    orderby onePerson.LastName, onePhone.Number
                    select new
                    {
                        onePerson.LastName,
                        onePerson.FirstName,
                        onePhone.Number
                    };

                foreach (var p in query) {
                    Console.WriteLine("User: {0} {1}, tel: {2}", p.LastName, p.FirstName, p.Number);
                }
            }
        }
    }
}
