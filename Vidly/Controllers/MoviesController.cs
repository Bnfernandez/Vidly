using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();;    
        }

        

        [Route("Movies/")]
        public ActionResult MoviesSummary()
        {
            var viewModel = new MoviesSummaryViewModel
            {
                Movies = _context.Movies.Include(m => m.MovieGenre).ToList()
            };

            return View(viewModel);
        }

        [Route("Movies/Detail/{id}")]
        public ActionResult MovieDetail(int id)
        {
            var movie = _context.Movies.Include(m => m.MovieGenre).SingleOrDefault(m => m.Id == id);

            var viewModel = new MovieDetailViewModel() {Movie = movie};


            return View(viewModel);
        }

        //mvcaction4 = quick way to create an action
        [Route("movies/released/{year:regex(\\d{4}):range(2014, 2019)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}