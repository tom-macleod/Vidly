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
        public ActionResult Index()
        {

            List<Customer> customers = getCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            return View(id);
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