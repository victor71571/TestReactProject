using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GridCore.Models;
using Microsoft.AspNetCore.Cors;

namespace GridCore.Controllers
{
    public class HomeController : Controller
    {
        private PetContext db;
        public HomeController(PetContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("api/home/getallpets")]
        [EnableCors("Allow")]
        public IEnumerable<Pet> GetAllPets()
        {
            return db.Pets.ToList();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
