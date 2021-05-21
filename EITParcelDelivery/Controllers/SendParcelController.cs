using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EITParcelDelivery.Models;

namespace EITParcelDelivery.Controllers
{
    public class SendParcelController : Controller
    {
        // GET: SendParcel
        public ActionResult Index()
        {
            var x = new SendParcelViewModel();
            x.Cities = new List<City>
            {
                new City { Id = 1, name = "Teehee", Available = true },
                new City { Id = 2, name = "Poopee", Available = false }
            };
            return View(x);
        }
    }
}