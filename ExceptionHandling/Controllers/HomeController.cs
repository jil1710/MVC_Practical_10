using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandling.Controllers
{
    public class HomeController : Controller
    {

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZeroException")]
        public ActionResult Index()
        {
            int a = 0;
            int b = 10;
            int c = b / a;
            ViewBag.Result = c;
            return View();
        }
    }
}