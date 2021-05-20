using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace EITParcelDelivery.Controllers
{
    public class apiController : Controller
    {
        public JsonResult parcelinformation(string source, string destination, int type, string token)
        {
            var data = new
            {
                available = true,
                price = 100,
                fee = 10,
                duration = 10
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}