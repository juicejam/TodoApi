using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult AjaxPost(string num)
        {
            num = $"请求成功，返回{num}";
            return Json(num, JsonRequestBehavior.AllowGet);
        }

        
        public ActionResult EditFormTest()
        {
            var sss = Request["ck"];
            var test = HttpContext.Request;
            return View();
        }

        [HttpPost]
        public ActionResult EditFormTest(FormContext test )
        {

            return View();
        }

    }
}