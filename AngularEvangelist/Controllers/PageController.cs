using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularEvangelist.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Forecast()
        {
            return View();
        }

        public ActionResult WeatherSearch()
        {
            return View();
        }

        public ActionResult UsersTable()
        {
            return View();
        }
    }
}