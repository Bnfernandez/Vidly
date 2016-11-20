using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        [Route("Movies/")]
        public ActionResult MoviesSummary()
        {
            var viewModel = new MovieFormViewModel()
            {
                Movies = _context.Movies.Include(m => m.MovieGenre).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    MovieGenres = _context.MovieGenres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var moveInDb = _context.Movies.Single(m => m.Id == movie.Id);

                moveInDb.Name = movie.Name;
                moveInDb.ReleaseDate = movie.ReleaseDate;
                moveInDb.NumberInStock = movie.NumberInStock;
                moveInDb.MovieGenreId = movie.MovieGenreId;
            }

            _context.SaveChanges();


            return RedirectToAction("MoviesSummary", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if(movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                MovieGenres = _context.MovieGenres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult New()
        {
            var genres = _context.MovieGenres;

            var viewModel = new MovieFormViewModel()
            {
                MovieGenres = genres
            };

            return View("MovieForm", viewModel);
        }
    }
};