using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewData_ViewBag_TempData_Session.Controllers
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
        public ActionResult ViewData_ViewBag_TempData_Session()
        {
            TempData["Name_Redirect"] = "TempData Name Update";
            return RedirectToAction("ViewData_ViewBag_TempData_Session1");
        }
        public ActionResult ViewData_ViewBag_TempData_Session1()
        {
            //ViewBag and ViewData has same keys then both carries same value and the value wil be last assigned
            //We can create ViewBag and can read with ViewData also and viceversa
            ViewBag.Name = "ViewBag Name";
            ViewData["Name"] = "ViewData Name";
            TempData["Name"] = TempData["Name_Redirect"];
            Session["Name"] = "Session Name";
            return View("~/Views/Home/ViewData_ViewBag_TempData_Session.cshtml");
        }
    }
}