using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie() { name = "Shrek" };
            List<Customer> customers = new List<Customer>
            {
                new Customer {name = "Customer 1" },
                new Customer {name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                movie = movie,
            customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/"+ month);
        }


    }
}