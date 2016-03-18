using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularEvangelist.Controllers
{
    public class DirectiveController : Controller
    {
        // GET: Directive
        public ActionResult HomeDirective()
        {
            return View();
        }

        public ActionResult ForecastPanel()
        {
            return View();
        }
    }
}