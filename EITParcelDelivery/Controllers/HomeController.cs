using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EITParcelDelivery.Library;

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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ShortestPath t = new ShortestPath();
            t.setSize(9);
            t.addUniEdge(0, 1, 4);
            t.addUniEdge(0, 7, 8);
            t.addUniEdge(1, 2, 8);
            t.addUniEdge(1, 7, 11);
            t.addUniEdge(2, 3, 7);
            t.addUniEdge(2, 5, 4);
            t.addUniEdge(2, 8, 2);
            t.addUniEdge(3, 4, 9);
            t.addUniEdge(3, 5, 14);
            t.addUniEdge(4, 5, 10);
            t.addUniEdge(5, 6, 2);
            t.addUniEdge(6, 8, 6);
            t.addUniEdge(7, 8, 16);

            //t.setGraph(new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            //    { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            //    { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            //    { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            //    { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            //    { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            //    { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            //    { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            //    { 0, 0, 2, 0, 0, 0, 6, 7, 0 } });
            t.dijkstra(0, 4);
            ViewBag.Message = "Your contact page." + t.toString();

            return View();
        }
    }
}