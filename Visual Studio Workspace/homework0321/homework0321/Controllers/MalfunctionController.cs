using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homework0321.Controllers
{
    public class MalfunctionController : Controller
    {
        //GET: Malfunction
        public ActionResult Interview4()
        {
            ViewBag.Controller = "Malfunction";
            ViewBag.Action = "Interview4";
            ViewBag.Message = "네번째 인터뷰";
            return View("Result");
        }
    }
}