using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            Customer customer1 = new Customer
            {
                name = "Superman",
                id = 1
            };
            Customer customer2 = new Customer
            {
                name = "Batman",
                id = 2
            };
            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer1);
            customerList.Add(customer2);

            CustomersViewModel viewModel = new CustomersViewModel();
            viewModel.customerList = customerList;

            return View(viewModel);
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Movie Page";

            return View();
        }





    }
}