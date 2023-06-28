using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practical_10.Controllers
{
    
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HandleError]
        public ActionResult Index(string name = "Mark")
        {
            ViewBag.Name = name;    
            return View();
        }
    }
}