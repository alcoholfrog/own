using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace homework0321
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // default 주석처리하고 얘만 살려놨을 때 왜 첫 화면이 뜨질 못하니...
            // url 쳐서 들어가면 들어가지긴 하지만...
            // 내가 생각했을 땐 자동으로 /Home/InterviewList/InterviewList 형태로 들어가질 것이었는데
            // 뭐가 문제인 것일까...
            // 신기한건 /Home/InterviewList만 써도 들어가짐 action이 없는데ㅔㅔㅔㅔ?
            routes.MapRoute("MyRoute", "{controller}/InterviewList/{action}",
                new { controller = "Home", action = "InterviewList" },
                new { Controller = "^Home$", action = "^Interview.*" }
            );

            /*
            routes.MapRoute("Default", "{controller}/{action}",
                new { controller = "Home", action = "InterviewList" },
                new { Controller = "^Home$", action = "^Interview.*" }
            );
             */
        }
    }
}
