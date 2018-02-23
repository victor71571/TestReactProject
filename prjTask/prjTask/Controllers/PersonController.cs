using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prjTask.Models;

namespace prjTask.Controllers
{
    public class PersonController : ApiController
    {
        PersonContext db = new PersonContext();
        [Route("api/Person/GetAllPersons")]
        public IEnumerable<Person> GetAllPersons()
        {
            return db.Persons.ToList();
        }
    }
}
