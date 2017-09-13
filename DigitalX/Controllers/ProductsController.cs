using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalX.Controllers
{
    public class ProductsController : Controller
    {
        GatDataServiceReference.GetDataServiceClient db = new GatDataServiceReference.GetDataServiceClient();
        // GET: Products
        public ActionResult Index()
        {
            var pro = db.ProductGetAll();
            return View(pro);
        }

        public ActionResult Details(int? id)
        {
            var pro = db.ProductGetDetails(id);
            return View(pro);
        }
    }
}