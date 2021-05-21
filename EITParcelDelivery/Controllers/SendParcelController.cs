using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EITParcelDelivery.Database.Repositories;
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
            var cr = new CitiesRepository();
            var ptr = new ParcelTypesRepository();
            vm.Cities = cr.getAll();
            vm.ParcelTypes = ptr.getAll();
            return View(vm);
        }
    }
}