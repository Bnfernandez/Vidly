using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>()
            {
                new Customer() { Name = "John Williams" , Id = 1},
                new Customer() { Name = "Alain Dupont" , Id = 2}
            };


        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        //[Route("movies/released/{year:regex(\\d{4}):range(2014, 2019)}/{month:regex(\\d{2}):range(1, 12)}")]
        [Route("customers/summary")]
        public ActionResult CustomersSummary()
        {
            var viewModel = new CustomersSummaryViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult CustomerDetail(int id)
        {
            Customer customerTemp = null;

            foreach (var customer in customers)
            {
                if (customer.Id == id)
                    customerTemp = customer;
            }
            var viewModel = new CustomerDetailViewModel() {Customer = customerTemp};


            return View(viewModel);
        }
    }
}