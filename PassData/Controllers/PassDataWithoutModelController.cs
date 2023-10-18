using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassData.Controllers
{
    public class PassDataWithoutModelController : Controller
    {
        // GET: PassDataWithoutModel
        public ActionResult Index()
        {
            ViewBag.age = 20;
            ViewBag.fullname  = "Arpit tathod";
            ViewBag.Status = true;
            ViewBag.Price = 4.5;
            ViewBag.Brithday =  DateTime.Now;
            ViewBag.Gender = "male";
            return View();
        }
    }
}