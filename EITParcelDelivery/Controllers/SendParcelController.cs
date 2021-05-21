using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EITParcelDelivery.Models;
using EITParcelDelivery.Repositories;

namespace EITParcelDelivery.Controllers
{
    public class SendParcelController : Controller
    {
        // GET: SendParcel
        public ActionResult Index()
        {
            var vm = new SendParcelViewModel();
            var rp = new CitiesRepository();
            vm.Cities = rp.getAll();
            return View(vm);
        }
    }
}