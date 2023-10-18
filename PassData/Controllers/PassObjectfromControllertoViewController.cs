using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using PassData.Models;

namespace PassData.Controllers
{
    public class PassObjectfromControllertoViewController : Controller
    {
        // GET: PassObjectfromControllertoView
        public ActionResult Index()
        {
            PassObjectProduct  product =new PassObjectProduct()
            {
                Id = "p01",
                Name = "Name 1",
                Photo ="133395009803041258.jpg",
                Price = "5.5",
                Quantity = "4",



            };
            ViewBag.Product = product; 
            return View();
        }
    }
}