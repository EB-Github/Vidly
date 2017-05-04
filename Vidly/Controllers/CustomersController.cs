using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.ViewModels;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer>customers = new List<Customer>()
            {
                new Customer {Name = "Freddy Joe", Id=1 },
                new Customer {Name = "Billie Jean", Id=2 }
            };
        // GET: Customers
        public ActionResult Index()
        {
            

            var viewModel = new ViewModelCustomers()
            {
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var customer = customers.Single(Customer => Customer.Id == id);
            return View(customer);
        }
    }
}