using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practical_10.Controllers
{
    public class AllActionResultController : Controller
    {
        // GET: AllActionResult
        public ContentResult ContentResult()
        {
            return Content("<h1>Example Of ContentResult</h1>","text/html",Encoding.UTF8);
        }

        public JavaScriptResult JavaScriptResult()
        {
            return JavaScript("alert('Example of JavascriptResult')");
        }


        public JsonResult JsonResult()
        {
            return Json(new { Name = "Jil", Age = 21 , College = "VGEC", Course = "IT"},JsonRequestBehavior.AllowGet);
        }

        public FileContentResult FileContentResult()
        {
            //var file  = System.IO.File.ReadAllBytes("~/Content/File.txt");
            var file = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/File.txt"));
            return new FileContentResult(file, "text/plain");
        }

        public FileResult FileResult()
        {
            return File("~/Content/File.txt", "text/plain", "File Result.txt");
        }

        public EmptyResult EmptyResult()
        {
            /// Login Implementation 
            return new EmptyResult();
        }

        public RedirectResult RedirectResult()
        {
            return Redirect("~/Employee/JIL");
        }

        public ViewResult ViewResult()
        {
            return View();
        }
    }
}