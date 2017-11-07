using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using U061117.Controllers;
using U061117.Models;

namespace U061117.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var MyApiURL = Url.RouteUrl(
        "DefaultApi",
        new { httproute = "", controller = "Product" },
        Request.Url.Scheme
                    );

            var model = new HttpClient()
               .GetAsync(MyApiURL)
               .Result
               .Content.ReadAsAsync<IEnumerable<Product>>().Result;

            return View(model);
        }
    }
}