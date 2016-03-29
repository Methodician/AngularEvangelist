using System.Web.Mvc;

namespace AngularEvangelist.Controllers
{
    public class WeatherController : Controller
    {
        public ActionResult Index()
        {
/*            HttpContext.Response.AppendHeader("Access-Control-Allow-Headers", "JSONP");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            HttpContext.Response.AppendHeader("Access-Control-Allow-Methods","GET");*/

            return View();
        }
    }
}