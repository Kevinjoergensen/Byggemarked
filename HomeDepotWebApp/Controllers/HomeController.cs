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
        public ActionResult Index()
        {
            List<Tool> tools = db.Tools.ToList<Tool>();
            return View(tools);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Om os.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt os.";
            return View();
        }
    }
}