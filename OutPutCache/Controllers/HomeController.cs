using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutPutCache.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(CacheProfile = "Cache5Min")]
        public ActionResult Index()
        {
            return View();
        }

    }
}