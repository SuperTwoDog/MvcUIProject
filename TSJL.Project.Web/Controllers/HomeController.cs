using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TSJL.Project.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "欢迎来到王者荣耀";
            return View();
        }

        public ActionResult Top()
        {
            ViewBag.UserName = "后羿";
            ViewBag.Level = "29";
            return View();
        }

        public ActionResult Left()
        {
            return View();
        }

        public ActionResult Right()
        {
            return View();
        }

    }
}