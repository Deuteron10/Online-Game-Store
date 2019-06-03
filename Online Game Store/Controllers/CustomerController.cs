using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Game_Store.Models; //importing Models
//using Online_Game_Store.ViewModels;

namespace Online_Game_Store.Controllers
{
    public class CustomerController : Controller
    {

        // GET: Customer
        public ViewResult Index()
        {

            /* var customers = new List<Customer>
             {
                 new Customer {Name = "John Doe", ID = 1},
                 new Customer {Name = "Jane Doe", ID = 2}
             };

             var customerIndexViewModel = new RandomGameViewModel
             {
                 Customers = customers
             }; 
             
             return View(customerIndexViewModel); */

            var customers = GetCustomers();

            return View(customers);

            
        }

        // GET: Customer/Details
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { ID = 1, Name = "John Smith" },
                new Customer { ID = 2, Name = "Mary Williams" }
            };
        }
    }
}