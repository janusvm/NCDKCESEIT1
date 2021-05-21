using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EITParcelDelivery.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string username, string password)
        {
            if (username == "poopen" && password == "farden")
            {
                return Json("Success!", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Failure!", JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}