using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyCourse.Models;

namespace VidlyCourse.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Cutomers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            /*                
               new List<Customer>();
            */

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault<Customer>(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers() { 
        
            return new List<Customer>
            {
                new Customer { Id=1, Name = "Ali" },
                new Customer { Id=2, Name = "Faisal" },
                new Customer { Id=3, Name = "Mesh" }
            };
        }
    }
}