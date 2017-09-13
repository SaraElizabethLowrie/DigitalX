using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalX.Controllers
{
    public class HomeController : Controller
    {
        GatDataServiceReference.GetDataServiceClient db = new GatDataServiceReference.GetDataServiceClient();
        public ActionResult Index()
        {
            var top = db.ProductGetTop(8);
            return View(top);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}