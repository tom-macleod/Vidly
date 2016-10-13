using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            Movie movie = _context.Movies.Include(m => m.genre).SingleOrDefault(m => m.id == id);

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

    }
}