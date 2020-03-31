﻿using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HomeDepotWebApp.Controllers
{
    public class HomeController : Controller
    {
        private HomeDepotContext db = new HomeDepotContext();
        private static Rent rent;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer req)
        {
            var customer = db.Customers.Where(c => c.Username.Equals(req.Username) && c.Password.Equals(req.Password)).FirstOrDefault();

            if(customer != null) {
                rent = new Rent
                {
                    Customer = customer
                };
                return RedirectToAction("Overview");
            } else {
                return RedirectToAction("Index");
            }
        }

        
        public ActionResult Overview()
        {
            List<Tool> tools = db.Tools.ToList<Tool>();
            
            return View(tools);
        }

        public ActionResult Book(int id)
        {
            Tool tool = db.Tools.Find(id);

            rent.RentTool = tool;

            return View("Book", rent);
        }

        [HttpPost]
        public ActionResult BookConfirm(Rent rente)
        {
            db.Rents.Add(rente);
            db.SaveChanges();
            return View(rente);
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