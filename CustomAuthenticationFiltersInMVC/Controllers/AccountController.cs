using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomAuthenticationFiltersInMVC.Models;
using System.Web.Security;

namespace CustomAuthenticationFiltersInMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User model)
        {
            if (model.Username == "User" && model.Password == "User")
            {
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}