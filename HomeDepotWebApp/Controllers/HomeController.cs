using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeDepotWebApp.Controllers
{
    public class HomeController : Controller
    {
        private HomeDepotContext db = new HomeDepotContext();
        public static Rent rent;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer req) {
            var customer = db.Customers.Where(c => c.Username.Equals(req.Username) && c.Password.Equals(req.Password)).FirstOrDefault();
            rent = new Rent();
            if(customer != null) {
                rent.Customer = customer;
                rent.CustomerID = customer.CustomerId;
                return RedirectToAction("Overview");
            } else {
                return RedirectToAction("Index");
            }
        }

        
        public ActionResult Overview()
        {
            Console.WriteLine(rent.Customer.Name);
            List<Tool> tools = db.Tools.ToList<Tool>();
            
            return View(tools);
        }

        public ActionResult Book(int id)
        {
            int ideet = id;

            Tool tool = db.Tools.Where(t => t.Id.Equals(ideet)).FirstOrDefault();
            rent.tool = tool;
            rent.ToolId = tool.Id;

            return View(rent);
        }

        [HttpPost]
        public ActionResult BookConfirm(Rent rent)
        {
            Customer c = rent.Customer;
            
            db.Rents.Add(rent);
            db.SaveChanges();
            return View(rent);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(Rent rent)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}