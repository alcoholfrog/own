using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework2015_01_25.Models;

namespace Homework2015_01_25.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Recom()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Recom(Board recom)
        {
            if (ModelState.IsValid)
            {
                
                string type = "추천";
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;

                recom.Type = type;
                recom.set_date_time(year, month, day, hour, minute, second);
                Board.Num_of_recom++;

                return View("Thanks", recom);
            }
            else
            {
                //유효성 검사 오류가 존재한다.
                return View();
            }
        }

        [HttpGet]
        public ViewResult Not_recom()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Not_recom(Board not_recom)
        {
            if (ModelState.IsValid)
            {
                string type = "비추천";
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;

                not_recom.set_date_time(year, month, day, hour, minute, second);
                not_recom.Type = type;
                Board.Num_of_not_recom++;

                return View("Thanks", not_recom);
            }
            else
            {
                //유효성 검사 오류가 존재한다.
                return View();
            }
        }
    }

    
}