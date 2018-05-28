using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using layoutassignment.Models;

namespace layoutassignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult CheckTemp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckTemp(double input)
        {
            ViewBag.Result = TempCheck.CheckTemp(input);
            return View();
        }
    }
}