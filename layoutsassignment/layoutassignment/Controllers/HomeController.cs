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
        public ActionResult GuessingGame()
        {
            Random Dice = new Random();
            Session["CorrectNumber"] = Dice.Next(1, 100);
            return View("game");
        }
        /* Action som laddas in första gången som sidan körs. Skapar en lokal instans av Dice för att ge min seesion "CorrectNumber" ett värde. */
        [HttpPost]
        public ActionResult GuessingGame(double input)
        {
            Guessing LocalGuessing = new Guessing();
            int.TryParse(Session["CorrectNumber"].ToString(), out int CorrectNumber);
            ViewBag.Result = LocalGuessing.NumberCheck(input, CorrectNumber);
            return View("game");
        }
        /* Action som körs tills sidan laddas om. Skapar en lokal instans av min "Guessing" model. Tar min session "CorrectNumber" och kontrollerar om värdet som är sparat som en string
         * kan konverteras till en int. Kan den så trycker den ut en int som heter "CorrectNumber". Viewbag presenterar resultatet.*/
    }
}