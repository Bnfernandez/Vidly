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

        [Route("Movies/")]
        public ActionResult MoviesSummary()
        {
            var movies = new List<Movie>()
            {
                new Movie() {Name = "Shrek"},
                new Movie() {Name = "Inception"}
            };

            var viewModel = new MoviesSummaryViewModel() {Movies = movies};

            return View(viewModel);
        }
        
        // GET: Movies
/*        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>()
            {
                new Customer() { Name = "Customer 1" },
                new Customer() { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers,
                Movie = movie
            };
            
            return View(viewModel);
        }*/

        //mvcaction4 = quick way to create an action
        [Route("movies/released/{year:regex(\\d{4}):range(2014, 2019)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}