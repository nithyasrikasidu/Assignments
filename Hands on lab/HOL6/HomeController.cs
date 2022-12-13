using Hands_on_lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hands_on_lab6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult GetServerTime()
        {
            System.Threading.Thread.Sleep(5000);
            return PartialView();
        }
        static List<User>users=new List<User>();
        public ActionResult GetAllUsers()
        {
            return PartialView(users);       
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User u) 
        {
            users.Add(u);
            return RedirectToAction("GetAllUsers");
        }
    }
}