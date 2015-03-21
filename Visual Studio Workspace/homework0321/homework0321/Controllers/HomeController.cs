using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homework0321.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult InterviewList()
        {
            return View();
        }

        public ActionResult Interview1()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Interview1";
            ViewBag.Message = "첫번째 인터뷰";
            return View("Result");
        }

        public ActionResult Interview2()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Interview2";
            ViewBag.Message = "두번째 인터뷰";
            return View("Result");
        }

        public ActionResult Detail3()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Detail3";
            ViewBag.Message = "세번째 인터뷰";
            return View("Result");
        }
    }
}