using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsDotNet.Models;
namespace CarsDotNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Here you will find a list of luxury cars that I hope to own one day";
            return View();
        }
        public ActionResult Mercedes()
        {
            ViewBag.Message = "First Class in Luxury";
            Mercedes myMercedes = new Mercedes("Mercedes", "SLS AMG", "Red");
            return View(myMercedes);
        }
        public ActionResult BMW()
        {
            ViewBag.Message = "BMW: The Ultimate Driving Machine";
            BMW myBmw = new BMW("BMW", "745li", "Black");
            return View(myBmw);
        }
        public ActionResult Lexus()
        {
            ViewBag.Message = "Lexus: Pursuit of Perfection";
            Lexus myLexus = new Lexus("Lexus", "LS 350", "Green");
            return View(myLexus);
        }
        public ActionResult Audi()
        {
            ViewBag.Message = "Audi: Truth in Engineering";
            Audi myAudi = new Audi("Audi", "A8", "Silver");
            return View(myAudi);
        }
        public ActionResult Maybach()
        {
            ViewBag.Message = "Maybach: Not so much a name as a philosophy";
            Maybach myMaybach = new Maybach("Maybach", "Phantom", "Black");
            return View(myMaybach);
        }
    }
}