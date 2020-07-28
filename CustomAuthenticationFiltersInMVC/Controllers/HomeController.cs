using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomAuthenticationFiltersInMVC.Filters;

namespace CustomAuthenticationFiltersInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[AniketAuthentication]
        [AniketAction]
        public ActionResult Index()
        {
            return View();
        }
    }
}