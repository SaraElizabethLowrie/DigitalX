using DigitalX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalX.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository iProductRepository = new ProductRepository();
        // GET: Cart
        public ActionResult Index()
        {
            return View("Index");
        }


        public ActionResult Buy(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item()
                {
                    product = iProductRepository.find(id),
                    quantity = 1
                });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExits(id);
                if (index == -1)
                {
                    cart.Add(new Item()
                    {
                        product = iProductRepository.find(id),
                        quantity = 1
                    });
                }
                else
                {
                    cart[index].quantity = cart[index].quantity + 1;
                }
                Session["cart"] = cart;
            }
            return View("Index");
        }

        private int isExits(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].product.ProductID == id)
                    return i;
            return -1;
        }

        public ActionResult Delete(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(id);
            Session["cart"] = cart;
            return View("Index");
        }
    }
}