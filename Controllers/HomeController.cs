using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace About_TR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "N/A";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Info";

            return View();
        }
        [Authorize]
        public ActionResult Bio()
        {
            ViewBag.Message = "Bio";

            return View();
        }
        [Authorize]
        public ActionResult Movies()
        {
            ViewBag.Message = "Movies";

            return View();
        }
        [Authorize]
        public ActionResult Books()
        {
            ViewBag.Message = "Books";

            return View();
        }
    }
}