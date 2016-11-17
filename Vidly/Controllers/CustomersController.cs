using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //[Route("movies/released/{year:regex(\\d{4}):range(2014, 2019)}/{month:regex(\\d{2}):range(1, 12)}")]
        [Route("customers/summary")]
        public ActionResult CustomersSummary()
        {
            var viewModel = new CustomersSummaryViewModel
            {
                Customers = _context.Customers.Include(c => c.MembershipType).ToList()
            };

            return View(viewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult CustomerDetail(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if(customer == null)
                return HttpNotFound();

            var viewModel = new CustomerDetailViewModel() {Customer = customer};

            return View(viewModel);
        }
    }
}