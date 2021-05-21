using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EITParcelDelivery.Database.Repositories;

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
            var userRepo = new UserRepository();
            var user = userRepo.get(username, password);
            if (user != null)
            {
                return Json(user.Id, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}