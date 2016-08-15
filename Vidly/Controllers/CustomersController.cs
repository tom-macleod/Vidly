using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers/Index")]
        public ActionResult Index()
        {

            List<Customer> customers = getCustomers();

            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = getCustomers().SingleOrDefault(c => c.id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }




        private List<Customer> getCustomers()
        {
            return new List<Customer>
            {
                new Customer { id = 1, name = "Superman" },
                new Customer { id = 2, name = "Batman" }
            };
        }

    }
}