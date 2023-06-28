using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practical_10.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult PageNotFoundError()
        {
            return View();
        }
    }
}