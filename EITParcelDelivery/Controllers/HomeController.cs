using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EITParcelDelivery.Code;
using System.Collections;
using System.Web.Script.Serialization;

namespace EITParcelDelivery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            webApiCall w = new webApiCall();
            JavaScriptSerializer JSS = new JavaScriptSerializer();
            Dictionary<string, object> parsedObj = JSS.Deserialize<Dictionary<string, object>>(w.getParcel());

            ViewBag.Message = "available: " + parsedObj["available"];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}