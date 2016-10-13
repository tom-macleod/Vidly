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

        public ActionResult Create()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.id == 0)
            {
                movie.dateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.id == movie.id);
                movieInDb.name = movie.name;
                movieInDb.releaseDate = movie.releaseDate;
                movieInDb.genreId = movie.genreId;
                movieInDb.numberInStock = movie.numberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Include(m => m.genre).Single(m => m.id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                movie = movie,
                genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
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