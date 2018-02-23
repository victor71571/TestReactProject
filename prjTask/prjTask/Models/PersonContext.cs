using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace prjTask.Models
{
    public class PersonContext: DbContext
    {
        public PersonContext() : base("PersonContext") { }
        public DbSet<Person> Persons { get; set; }
    }
}