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
        public ActionResult Index()
        {
            var movies = getMovies();
            return View(movies);
        }


        public ActionResult Details(int id)
        {
            Movie movie = getMovies().SingleOrDefault(c => c.id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        // GET: Movies/Random
        [Route("Movies/Random")]
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


        private List<Movie> getMovies()
        {
            return new List<Movie>
            {
                new Movie { id = 1, name = "300 Spartans" },
                new Movie {id = 2, name = "The Raid" }
            };
        }

    }
}