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
                var query = from utente in context.Utenti
                    where utente.FirstName == "Roberto" && utente.LastName.Contains("ar")
                    orderby utente.LastName ascending
                    select utente;

                // selezione di un singolo record
                var first = query.First();
                var firstOrNull = query.FirstOrDefault();

                // method
                var methodQuery = context.Utenti.Where(p => p.BusinessEntityID <= 6);
                Console.WriteLine("fine");
            }
        }

        private void cmdQuantifiers_Click(object sender, EventArgs e)
        {
            using (var context = new AdvContext()) {
                var hasDoes = (from utente in context.Utenti
                    where utente.LastName == "Doe"
                    select utente).Any();

                hasDoes = context.Utenti.Any(p => p.LastName == "Doe");
                var allHaveJ = context.Utenti.All(p => p.FirstName.Contains("J"));
            }
        }

        private void cmdRelation_Click(object sender, EventArgs e)
        {
            using (var context = new AdvContext()) {
                //context.Configuration.LazyLoadingEnabled = true;
                //var query = context.Utenti.Where(w => w.BusinessEntityID < 4).Include(p => p.PhoneNumbers).ToList();

                /*
                var query2 = (from utente in context.Utenti.Include(p => p.PersonPhone)
                             where utente.BusinessEntityID < 4
                             select utente).ToList();
                */

                var query = (from utente in context.Utenti
                             where utente.BusinessEntityID < 4
                             select utente).ToList();

                foreach (Person p in query) {
                    Console.WriteLine(p.PersonPhone.FirstOrDefault()?.Number);
                }
                
                /*
                var query2 = from utente in context.Utenti.Include(p => p.PersonPhone)
                    where utente.PersonPhone.Any(ph => ph.Number.StartsWith("6"))
                    select utente;

                foreach (Person p in query2) {
                    Console.WriteLine(p.PersonPhone.FirstOrDefault()?.Number);
                }
                */
                
                Console.WriteLine("fine");
            }
        }

    }
}
