using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthenticationFiltersInMVC.Filters
{
    public class AniketAction : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("hello from action filter = OnActionExecuted");
            filterContext.Controller.ViewBag.Msg = "Aniket From Action Filters";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("hello from action filter = OnActionExecuting");
            //throw new NotImplementedException();
        }
    }
}