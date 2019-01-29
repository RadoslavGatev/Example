using Example.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.FullWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new Repo();
            return View(model: repo.Get());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}